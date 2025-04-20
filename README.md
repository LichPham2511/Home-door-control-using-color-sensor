# Home door control using color sensor
Teamwork

## Introduction

This project is a **Smart Door Control System** that uses **color sensors** to automatically open or close the door, communicating via **UART (Universal Asynchronous Receiver/Transmitter)**.  
It's designed for smart homes, labs, or office environments to improve convenience and safety.

---

## Key Features

- Automatic door control based on color recognition  
- UART communication between microcontroller and door control module
- Visual data transmission and reception through a C# interface
- Secure access using unique color code authentication    

---

## Technologies Used

- **Microcontroller:** Arduino Nano
- **Color Sensor:** TCS34725 
- **Communication:** UART protocol  
- **Programming Language:** C/C++  
- **GUI:** Visual studio (C#)

---

## UART Communication Overview

**UART (Universal Asynchronous Receiver-Transmitter)** is a widely used serial communication protocol that allows asynchronous data exchange between devices. It is commonly found in IoT systems and embedded platforms like Arduino, Raspberry Pi, and modules such as Wi-Fi, Bluetooth, RFID readers, and Xbee.

### Communication Lines:
- **TX (Transmit)** – sends data  
- **RX (Receive)** – receives data

![image](https://github.com/user-attachments/assets/0b3e95f2-7e10-48ca-8d67-6ae581967e9e)

Unlike synchronous communication, UART does **not use a clock signal**. Instead, it marks the start and end of each data frame using **start and stop bits**. This allows devices to communicate accurately without being time-locked to a shared clock.

---

### How UART Works

1. **Data Source**: The UART transmitter receives parallel data from a data bus (e.g., CPU, RAM, microcontroller) and converts it into a serial stream.

2. **Packet Format**:
   - **Start Bit**: Indicates the beginning of transmission (logic low).
   - **Data Bits**: 5 to 9 bits, sent with the Least Significant Bit (LSB) first.
   - **Parity Bit (optional)**: Used for error checking (even or odd).
   - **Stop Bit(s)**: 1 to 2 bits to mark the end of the frame (logic high).

3. **Operating Modes**:
   - **Simplex**: One-way communication only.
   - **Half-Duplex**: Two-way communication, but only one direction at a time.
   - **Full-Duplex**: Simultaneous two-way communication.

![image](https://github.com/user-attachments/assets/5d7d654b-73d2-4bfc-a3e4-b24f6aa93cc8)


4. **Reception Process**: The receiving UART decodes the serial stream on the RX line, removes the start, parity, and stop bits, and then delivers the parallel data to the receiving system.

This method is efficient for low-speed, short-distance communication and is widely used due to its simplicity and reliability.


## Conclusion

This project demonstrates a practical application of color recognition and UART communication in smart home automation.  
By combining hardware and software effectively, it provides a secure and convenient solution for door control systems.  

The project is open for future improvements such as mobile app integration, voice control, or IoT-based remote monitoring.  
Feel free to explore, contribute, and customize it for your own smart home needs.
