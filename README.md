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

## System Analysis and Design

### 1. System Block Diagram Design

![image](https://github.com/user-attachments/assets/46403f39-3cfd-46e2-875d-90d3e1a91a6a)

   #### Functional Description of Each Block:

- **Power Supply Block**:  
  Provides stable power to ensure all components operate reliably.

- **Central Processing Block**:  
  Contains the Arduino, which acts as the "brain" of the system. It handles communication and data exchange with the UART block and sends control signals to the actuator (Servo).

- **Sensor Input Block**:  
  Collects data from sensors and sends it to the central processor via the UART interface.

- **UART Communication Block**:  
  Handles serial data transmission between components, acting as the communication bridge within the system.

- **GUI Block**:  
  Represents the user interface built with Visual Studio (C#). It sends commands to the actuator (Servo) through the central processor (Arduino).

- **Actuator Block**:  
  Consists of a Servo motor that executes actions based on control signals received from the Arduino.

### 2. Schematic Diagram

![image](https://github.com/user-attachments/assets/af7536f1-52ff-4430-9f26-c3b58cc1c21f)

### 3. PCB circuit design using Altium Designer

   #### PCB Design Requirements

Based on the initial requirements and the project context, the PCB was designed with the following standards:

- Components are arranged neatly to optimize the overall layout.
- Similar components are grouped together for better organization.
- LEDs are positioned at visible angles for easy real-time status monitoring.
- The PCB includes the team logo for easy identification and branding.
- The board dimensions are 5 x 8 cm, ensuring a compact yet fully functional design.
- Two-layer routing is used with a trace width of 0.2 mm.
- Via hole size is set to 0.7 mm.

   #### 2D and 3D PCB models

<p align="center">
  <img src="https://github.com/user-attachments/assets/2d69ee22-14b0-4231-921f-296dfd2cecc8" width="45%" />
  <img src="https://github.com/user-attachments/assets/df5c0344-811e-4304-847f-e230b733ee1f" width="45%" />
</p>

### 4. C# Interface Design

One of the most important components of the project is the user interface, which displays the current status and manages UART communication. The interface includes the following features:

- COM Port Selection: Select the available COM port and choose a baud rate.
- Connect / Disconnect: Easily connect to or disconnect from the selected serial port.
- Color Display from Sensor: Receive and display color data sent from the sensor.
- UART Data Testing: Send and receive test data through UART for communication verification.
- Quick Text Function: Send a quick test message of 100 characters ('A') and display the number of characters sent and received.

![image](https://github.com/user-attachments/assets/2283dd9a-a03e-4c67-8052-8063c804fa83)

### 5. Simulated door model on tinkercad

![image](https://github.com/user-attachments/assets/fb6ae1fa-3268-40bc-92e6-41793443888f)

---

## Conclusion

This project demonstrates a practical application of color recognition and UART communication in smart home automation.  
By combining hardware and software effectively, it provides a secure and convenient solution for door control systems.  

The project is open for future improvements such as mobile app integration, voice control, or IoT-based remote monitoring.  
Feel free to explore, contribute, and customize it for your own smart home needs.
