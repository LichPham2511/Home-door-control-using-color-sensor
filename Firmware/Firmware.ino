#include <SoftwareSerial.h>  // Thư viện để sử dụng giao tiếp Serial qua các chân ngoài
#include <Servo.h>           // Thư viện điều khiển các động cơ servo

// Khởi tạo đối tượng mySerial để giao tiếp với thiết bị qua cổng Serial ngoài
SoftwareSerial mySerial(10, 11); // Arduino RX ở chân 10 và TX ở chân 11

Servo myServo;  // Khởi tạo đối tượng Servo 1
Servo myServo1; // Khởi tạo đối tượng Servo 2

// Khai báo các chân để điều khiển LED RGB
const int red = 2;
const int green = 3;
const int blue = 4;

// Kích thước buffer để nhận dữ liệu
const int BUFFER_SIZE = 11;
unsigned char Re_buf[BUFFER_SIZE], counter = 0;  // Buffer nhận dữ liệu
unsigned char sign = 0;  // Biến để kiểm tra tín hiệu đã nhận
byte rgb[3] = {0};  // Mảng lưu trữ giá trị RGB nhận được

// Biến lưu thời gian
unsigned long previousMillis = 0;
const long interval = 100;  // Thời gian in dữ liệu (ms)

void setup() {
  Serial.begin(7200);  // Khởi tạo giao tiếp serial với tốc độ 7200 baud
  mySerial.begin(9600); // Khởi tạo giao tiếp với module ngoài qua mySerial, tốc độ 9600 baud
  mySerial.listen();    // Lắng nghe dữ liệu từ mySerial
  delay(10);  // Đợi một chút để ổn định giao tiếp
  
  mySerial.write(0xA5);  // Gửi byte 0xA5 để bắt đầu giao tiếp
  
  mySerial.write(0x01);  // Lệnh khởi tạo, chế độ xuất liên tục
  mySerial.write(0xA6);  // Lệnh tiếp theo để khởi tạo chế độ

  myServo.attach(6);   // Gắn servo1 vào chân 6
  myServo1.attach(9);  // Gắn servo2 vào chân 9

  // Đặt các chân LED RGB làm OUTPUT
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
} 

void loop() {
  char input = Serial.read();  // Đọc ký tự từ cổng Serial (dùng để điều khiển servo và LED)
  int vl1 = 90, pos;
  
  // Kiểm tra xem có dữ liệu nào từ mySerial chưa
  while (mySerial.available()) {   
    Re_buf[counter] = (unsigned char)mySerial.read();  // Đọc dữ liệu vào buffer
    
    if (counter == 0 && Re_buf[0] != 0x5A) return; // Kiểm tra tiêu đề khung, nếu không phải 0x5A thì thoát
    counter++;
    
    // Nếu buffer đầy (tối đa BUFFER_SIZE) thì reset counter để chuẩn bị cho lần đọc tiếp theo
    if (counter >= BUFFER_SIZE) {
      counter = 0;
    }

    // Khi đủ 8 byte (khung dữ liệu hoàn chỉnh)
    if (counter == 8) {
      counter = 0;  // Reset counter để chuẩn bị cho khung tiếp theo
      sign = 1;     // Đánh dấu rằng dữ liệu đã sẵn sàng
    }      
  }
  
  if (sign) {  // Nếu đã nhận được đầy đủ dữ liệu
    sign = 0;  // Reset dấu hiệu

    unsigned char sum = 0;
    // Tính tổng các byte trong khung dữ liệu (để kiểm tra checksum)
    for (unsigned char i = 0; i < 7; i++) {
        sum += Re_buf[i];
    }
    
    if (sum == Re_buf[7]) { // Kiểm tra checksum (tổng các byte có bằng byte cuối không)
      rgb[0] = Re_buf[4];  // Lưu giá trị RGB vào mảng
      rgb[1] = Re_buf[5];
      rgb[2] = Re_buf[6];

      // Kiểm tra màu sắc nhận được và điều khiển các thiết bị tương ứng
      if ((rgb[0] > rgb[1] && rgb[0] > rgb[2]) || input == 'r') {  // Nếu màu đỏ lớn nhất hoặc nhận lệnh 'r'
        mySerial.end();  // Kết thúc giao tiếp serial
        digitalWrite(red, HIGH);  // Bật LED đỏ
        digitalWrite(green, LOW);  // Tắt LED xanh lá
        digitalWrite(blue, LOW);  // Tắt LED xanh dương
        Serial.println('R');  // Gửi thông báo màu đỏ tới Serial Monitor

        myServo1.attach(9);  // Kết nối servo1
        delay(15); 
         
        myServo1.write(vl1);  // Quay servo1 đến góc 90 độ
        delay(500);
        
        myServo.attach(6);  // Kết nối lại servo2
        if(vl1 == 90)
        {
          // Quay servo2 từ góc 0 đến 100 độ
          for (int pos = 0; pos <= 100; pos += 1) {
            myServo.write(pos);  // Điều khiển servo2
            delay(15);  // Đặt thời gian chờ để servo di chuyển
          }  
        } 

        delay(5000);  // Chờ 5 giây
        // Quay servo2 lại từ 100 độ về 0 độ
        for (int pos = 100; pos >= 0; pos -= 1) {
          myServo.write(pos);  
          delay(15);  // Đặt thời gian chờ để servo di chuyển
        }
        
        if(pos == 0) {  // Khi servo quay về 0 độ
          delay(700);  // Chờ 700ms
          myServo1.write(0);  // Quay servo1 về vị trí ban đầu
        }
        
        delay(15);
        myServo.detach();  // Tháo servo2 ra khỏi chân để giảm tải
        delay(2000);  // Chờ 2 giây
        mySerial.begin(9600);  // Khởi động lại giao tiếp serial
      } 
      else if ((rgb[1] > rgb[0] && rgb[1] > rgb[2]) || input == 'g') {  // Nếu màu xanh lá lớn nhất hoặc nhận lệnh 'g'
        Serial.println('G');  // Gửi thông báo màu xanh lá tới Serial Monitor

        digitalWrite(red, LOW);  // Tắt LED đỏ
        digitalWrite(green, HIGH);  // Bật LED xanh lá
        digitalWrite(blue, LOW);  // Tắt LED xanh dương
        myServo1.attach(9);  // Kết nối servo1
        delay(15);
        myServo1.write(90);  // Quay servo1 đến góc 90 độ
        delay(15);
        myServo.detach();  // Tháo servo2
        myServo1.detach();  // Tháo servo1
      } 
      else if ((rgb[2] > rgb[0] && rgb[2] > rgb[1]) || input == 'b') {  // Nếu màu xanh dương lớn nhất hoặc nhận lệnh 'b'
        Serial.println('B');  // Gửi thông báo màu xanh dương tới Serial Monitor

        digitalWrite(red, LOW);  // Tắt LED đỏ
        digitalWrite(green, LOW);  // Tắt LED xanh lá
        digitalWrite(blue, HIGH);  // Bật LED xanh dương

        myServo1.attach(9);  // Kết nối servo1
        delay(15);
        myServo1.write(0);  // Quay servo1 đến góc 0 độ
        delay(15);
        myServo.detach();  // Tháo servo2
        myServo1.detach();  // Tháo servo1
      } 
      else {  // Nếu không nhận diện được màu sắc rõ ràng
        mySerial.begin(9600);  // Khởi động lại giao tiếp serial
        Serial.println("n");  // Gửi thông báo "n" nếu không nhận diện được màu sắc

        digitalWrite(red, LOW);  // Tắt tất cả các LED
        digitalWrite(green, LOW);
        digitalWrite(blue, LOW);  

        myServo.detach();  // Tháo servo2
        myServo1.detach();  // Tháo servo1
        delay(15);
      }
    }
  } 
}
