using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;




namespace gui2
{
    public partial class Form1 : Form
    {
        string receivedata = string.Empty;
        string transmitdata = String.Empty;

        private StringBuilder bufferData = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "chon cong com...";
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                COMPORT.Items.Add(port);
            }
        }
        public void send_data(string sent_text)
        {
            serialPort1.Write(sent_text);
            TEXTSEND.Text = sent_text.ToString();
        }
        private void Form1_formclosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void CONNECT_Click(object sender, EventArgs e)
        {
            if (COMPORT.Text == "")
                MessageBox.Show(" chon cong com", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (COMPORT.Text == "")
                MessageBox.Show("chon baudrate cho com", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("cong com da san sang va su dung cho", "thontin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        MessageBox.Show(COMPORT.Text + "da ket noi", "thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        THONGBAO.BackColor = Color.Lime;

                        THONGBAO.Text = " CONNECTED ";

                        COMPORT.Enabled = false;
                        BAUDRATE.Enabled = false;

                        string receivedata = string.Empty;
                        string transmitdata = String.Empty;
                    }
                }
                catch (Exception)
                {
                    THONGBAO.BackColor = Color.Red;
                    THONGBAO.Text = "Disconnected!";
                    // Hieu chinh mau va thong tin
                    MessageBox.Show("COM Port is not found. Please check your COM or Cable.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DISCONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    // Xu ly truong hop da ket noi
                    serialPort1.Close();
                    THONGBAO.BackColor = Color.Red;
                    // Hieu chinh mau va thong tin
                    THONGBAO.Text = "Disconnected!";
                    MessageBox.Show("COM Port is disconnected.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    COMPORT.Enabled = true;
                    BAUDRATE.Enabled = true;
                }
                else
                {
                    // Xu ly truong hop chua ket noi
                    MessageBox.Show("COM Port have been disconnected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                // Xu ly khi xuat hien loi
                MessageBox.Show("Disconnection appears error. Unable to disconnect.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit the program?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                if (serialPort1.IsOpen) // Dong cong neu cong dang duoc mo.
                {
                    serialPort1.Close();
                }
                this.Close();
            }
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (serialPort1.IsOpen)
            //    {
            //        transmitdata = TEXTSEND.Text.ToString();
            //        send_data(transmitdata); // Gui du lieu qua port noi tiep
            //                                 // guidulieu(transmitdata);
            //    }
            //    else
            //    {
            //        THONGBAO.BackColor = Color.Red; // Hieu chinh mau va thong tin
            //        THONGBAO.Text = "Disconnected!";
            //        MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Thong bao loi neu chua chon cong COM.
            //    }
            //}
            //catch (Exception)
            //{
            //    // Xu ly khi xuat hien loi
            //    MessageBox.Show("The control appears error. Action can not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                if (serialPort1.IsOpen)
                {
                    transmitdata = TEXTSEND.Text.ToString();

                    if (!string.IsNullOrEmpty(transmitdata))
                    {
                        send_data(transmitdata); // Gửi dữ liệu từ TEXTSEND

                        // Delay sau khi gửi
                        System.Threading.Thread.Sleep(100); // Delay 100 ms

                        // Đếm số ký tự trong TEXTSEND và ghi vào sosend
                        int charCount = transmitdata.Length;
                        sosend.Invoke(new MethodInvoker(delegate { sosend.Text = charCount.ToString() + " kí tự" ; 
                        }));
                    }
                }
                else
                {
                    THONGBAO.BackColor = Color.Red; // Hiệu chỉnh màu và thông tin
                    THONGBAO.Text = "Disconnected!";
                    MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Thông báo lỗi nếu chưa chọn cổng COM.
                }
            }
            catch (Exception)
            {
                // Xử lý khi xuất hiện lỗi
                MessageBox.Show("The control appears error. Action cannot be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void COMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            THONGBAO.BackColor = Color.Red;
            THONGBAO.Text = "DISCONNECTED!";
            serialPort1.PortName = COMPORT.Text;
        }

        private void BAUDRATE_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            THONGBAO.BackColor = Color.Red;
            THONGBAO.Text = "DISCONNECTED!";
            serialPort1.BaudRate = Convert.ToInt32(BAUDRATE.Text);
        }

        
        //Phương thức gửi dữ liệu người dùng nhập vào
        //private void guidulieu()
        //{
        //    // Lấy dữ liệu từ một TextBox (textBox_Input) mà người dùng nhập vào
        //    string dataToSend = TEXTSEND.Text.ToString();

        //    if (!string.IsNullOrWhiteSpace(dataToSend)) // Kiểm tra nếu dữ liệu không trống
        //    {
        //        //serialPort1.Write(dataToSend); // Gửi dữ liệu qua cổng Serial

        //        TEXTRECEIVE.Invoke(new MethodInvoker(delegate
        //        {
        //            TEXTRECEIVE.Text = dataToSend; // Ghi đè dữ liệu vào TEXTRECEIVE
        //        }));
        //    }
        //}
        //Phương thức gửi phản hồi
        //private void phanhoi(string message)
        //{
        //    // Gửi lại phản hồi dữ liệu đã nhận
        //    serialPort1.Write(message); // Không thêm ký tự kết thúc 
        //    TEXTRECEIVE.Invoke(new MethodInvoker(delegate
        //    {
        //        TEXTRECEIVE.Text = message; // Ghi đè dữ liệu vào TEXTRECEIVE
        //    }));
        //    //TEXTRECEIVE.Text = message; // Ghi đè dữ liệu vào TEXTRECEIVE
        //}

        private void checkBox_DataSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DataSend.Checked == true)
            {
                SEND.Enabled = true; // Cho phep nhap chuoi du lieu vao o Send
                TEXTSEND.ReadOnly = false;
            }
            else
            {
                SEND.Enabled = false;
                TEXTSEND.ReadOnly = true;
            }
        }

        // Phương thức sinh chuỗi ký tự ngẫu nhiên
        private void Send100Characters()
        {
            string testData = new string('A', 100); // Tạo chuỗi gồm 100 ký tự 'A'
            System.Threading.Thread.Sleep(100);
            send_data(testData); // Gửi chuỗi này đi
            sosend.Text = "100 kí tự";
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;

            ////receivedata = serialPort1.ReadLine();
            //receivedata = serialPort1.ReadExisting();
            //if (!string.IsNullOrEmpty(receivedata))
            //{
            //    // Cập nhật TEXTRECEIVE với dữ liệu nhận được
            //    TEXTRECEIVE.Invoke(new MethodInvoker(delegate
            //    {
            //        TEXTRECEIVE.Text = receivedata.ToString();

            //        System.Threading.Thread.Sleep(100); // Delay 100 ms

            //        // Đếm số ký tự trong TEXTRECEIVE và ghi vào soreceive
            //        int charCount = receivedata.Length;
            //        soreceive.Invoke(new MethodInvoker(delegate { soreceive.Text = charCount.ToString() + " kí tự"; 
            //        }));
            //    }));

            //    // Kiểm tra dữ liệu nhận được và cập nhật màu cho các ô LED
            //    if (receivedata == "R")
            //    {
            //        // Nếu nhận được "R", bật led đỏ và tắt các led còn lại
            //        colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.Red; }));
            //        colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
            //        colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

            //        THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_red"; }));


            //    }
            //    else if (receivedata == "G")
            //    {
            //        // Nếu nhận được "G", bật led xanh lá và tắt các led còn lại
            //        colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
            //        colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.Green; }));
            //        colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

            //        THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_green"; }));
            //    }
            //    else if (receivedata == "B")
            //    {
            //        // Nếu nhận được "B", bật led xanh dương và tắt các led còn lại
            //        colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
            //        colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
            //        colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.Blue; }));

            //        THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_blue"; }));
            //    }
            //    else if (receivedata == "n")
            //    {
            //        colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
            //        colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
            //        colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

            //        THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "No color"; }));
            //    }
            //    /*else
            //    {
            //        // Nếu nhận dữ liệu không hợp lệ, tắt tất cả các led
            //        colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
            //        colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
            //        colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

            //        THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "No color"; }));
            //    }*/
            //}
            //else
            //{
            //    // Nếu không nhận được dữ liệu, chương trình sẽ tiếp tục đợi
            //    TEXTRECEIVE.Invoke(new MethodInvoker(delegate
            //    {
            //        TEXTRECEIVE.Text = "Đang chờ dữ liệu...";
            //    }));
            //}

            CheckForIllegalCrossThreadCalls = false;

            receivedata = serialPort1.ReadExisting(); 

            bufferData.Append(receivedata);  // *Thêm dữ liệu vào bộ đệm*

            if (bufferData.Length > 0)
            {
                TEXTRECEIVE.Invoke(new MethodInvoker(delegate
                {
                    TEXTRECEIVE.Text = bufferData.ToString();  // *Hiển thị toàn bộ dữ liệu đã nhận*

                    System.Threading.Thread.Sleep(100);

                    int charCount = bufferData.Length;
                    soreceive.Invoke(new MethodInvoker(delegate { soreceive.Text = charCount.ToString() + " kí tự"; }));
                }));

                if (bufferData.ToString().Contains("R"))
                {
                    colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.Red; }));
                    colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
                    colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

                    THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_red"; }));
                }
                else if (bufferData.ToString().Contains("G"))
                {
                    colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
                    colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.Green; }));
                    colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

                    THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_green"; }));
                }
                else if (bufferData.ToString().Contains("B"))
                {
                    colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
                    colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
                    colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.Blue; }));

                    THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "color_blue"; }));
                }
                else if (bufferData.ToString().Contains("n"))
                {
                    colorred.Invoke(new MethodInvoker(delegate { colorred.BackColor = Color.White; }));
                    colorgreen.Invoke(new MethodInvoker(delegate { colorgreen.BackColor = Color.White; }));
                    colorblue.Invoke(new MethodInvoker(delegate { colorblue.BackColor = Color.White; }));

                    THONGBAOMAU.Invoke(new MethodInvoker(delegate { THONGBAOMAU.Text = "No color"; }));
                }

                bufferData.Clear();  // *Xóa dữ liệu trong bộ đệm sau khi đã xử lý*
            }
            else
            {
                TEXTRECEIVE.Invoke(new MethodInvoker(delegate { TEXTRECEIVE.Text = "chuoi nhan rong"; }));
            }

        }

        private void testnhanh_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                System.Threading.Thread.Sleep(100);
                Send100Characters(); // Gọi hàm gửi 100 ký tự
                System.Threading.Thread.Sleep(100);
            }
            else
            {
                MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
