\# Employee Attendance \& Activity Logging System



This is a Windows Forms application I built as a university project to track employees, their daily attendance and simple activity notes.  

The system stores the data in a MySQL database and is designed as a small example of a real-world attendance and logging system.



\## Features



\- Add, edit and delete employees

\- Record daily attendance (check-in / check-out)

\- Mark attendance status as Present, Absent or Late

\- Add a short activity / note for each employee

\- View and search attendance records

\- Basic role-based use (Admin / Employee) depending on the database data



\## Tech Stack



\- C# (.NET, Windows Forms)

\- MySQL

\- Visual Studio



\## How to run



```bash

1\. Clone the project



&nbsp;  git clone https://github.com/mhelail/CalisanTakipSistemi.git

&nbsp;  cd CalisanTakipSistemi



2\. Create the database in MySQL



&nbsp;  - Create a database named CalisanTakipDB

&nbsp;  - Run the SQL scripts that create:

&nbsp;    - Tables (Users, Employees, Attendance, AuditLogs)

&nbsp;    - Stored procedures (for Users, Employees, Attendance, AuditLogs)

&nbsp;    - Triggers (for attendance checks and logging)

&nbsp;  - The SQL code is the same as the one I used in my report for this project.



3\. Open the solution in Visual Studio



&nbsp;  - Open WinFormsApp1.sln



4\. Update the connection string



&nbsp;  - Open App.config

&nbsp;  - Set your own:

&nbsp;    - server

&nbsp;    - user id

&nbsp;    - password

&nbsp;    - database (should be CalisanTakipDB)



5\. Build and run



&nbsp;  - Build the project in Visual Studio

&nbsp;  - Run the application



