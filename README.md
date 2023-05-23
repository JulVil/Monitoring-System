# CNC Router Access Control Application

The CNC Router Access Control Application is a desktop application developed using C# that enables users to control access to a CNC Router machine. The primary objective of this application is to provide a means of monitoring and managing user activities on the CNC Router, allowing for tracking of machine usage, identifying potential causes of breakdowns, and determining the responsible users. The way they mantain a control of the students who use the machine, was a pen and paper list, trusting blindly on the user to report problems. But most of the times the users never reported the breakdowns and left the machine unusable for other students, specially in the most critical time of end term projects.

This was the final project of my mechatronic engineering degree. It was prototyped, tested, and presented in front of group of professors.

## Problem Statement

Controlling access to the CNC Router and keeping track of user activities is essential for maintaining the machine's integrity and ensuring accountability. The CNC Router Access Control Application addresses the following key challenges:

1. <ins>Lack of user control:</ins> Without an access control system, anyone can operate the CNC Router, potentially leading to unauthorized or improper usage.
2. <ins>Difficulty in identifying responsible users:</ins> In the event of a machine breakdown or error, it becomes challenging to determine who was using the CNC Router at the time.
3. <ins>Inefficient tracking of machine usage:</ins> Without a centralized system, it is cumbersome to monitor and analyze machine usage patterns, making it difficult to identify potential issues or schedule maintenance.

## Features

The CNC Router Access Control Application offers the following features:

1. User Registration: Students, who are the primary users, can register their information in the application. This includes details such as name, contact information, and any other relevant data.
2. Access Control: Once registered, students can use the application to gain access to the CNC Router. The application communicates with an Arduino to control the voltage required to start the CNC Router.
3. User Activity Logging: The application records user activities, such as the date, time, and duration of machine usage. This information is stored in a SQL database, enabling comprehensive tracking of user interactions with the CNC Router.
4. Administrator Account: An administrator account is provided for authorized personnel to manage the system. The admin account offers features like viewing a table of all registered students and generating graphical representations of student information.
5. User Management: The admin account allows for adding, modifying, or removing student records, ensuring an up-to-date user database.

## Technologies Used

The CNC Router Access Control Application was created with the following technologies:

1. [C#](https://learn.microsoft.com/en-us/dotnet/csharp/) (C Sharp): The application is developed using the C# programming language. C# is a versatile and powerful language for creating desktop applications in the .NET framework.
2. [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-7.0): The graphical user interface (GUI) of the application is designed using Windows Forms, a component of the .NET framework. Windows Forms provides a rich set of controls and tools for creating intuitive desktop applications.
3. [SQL Database](https://www.mysql.com/): A SQL database is utilized to store user information and log CNC Router usage data. SQL provides a robust and efficient means of storing and retrieving structured data.
4. [Arduino](https://www.arduino.cc/): The application interfaces with an Arduino microcontroller to control the voltage required to start the CNC Router. The Arduino receives signals from the application and activates the appropriate circuitry.

## Conclusion

The CNC Router Access Control Application provides a comprehensive solution for managing and monitoring user access to a CNC Router. By utilizing C# for application development, SQL for data storage, and Arduino for voltage control, this application ensures efficient tracking of user activities and facilitates machine maintenance and accountability. With its user-friendly interface and admin features, the application simplifies the process of managing student records and offers insights into machine usage through graphical representations.

## Screenshots

<img src="https://github.com/JulVil/Monitoring-System/blob/master/.github/sm1.png" width=75% height=75%>
<img src="https://github.com/JulVil/Monitoring-System/blob/master/.github/sm2.png" width=75% height=75%>
<img src="https://github.com/JulVil/Monitoring-System/blob/master/.github/sm3.png" width=75% height=75%>
