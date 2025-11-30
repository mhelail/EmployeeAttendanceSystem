# Çalışan Takip Sistemi (Employee Attendance & Activity Logging System)

This is a Windows Forms application I built as a university project to track employees, their daily attendance and simple activity notes.  
The system stores the data in a MySQL database and is designed as a small example of a real-world attendance and logging system.

## Features

- Add, edit and delete employees
- Record daily attendance (check-in / check-out)
- Mark attendance status as Present, Absent or Late
- Add a short activity / note for each employee
- View and search attendance records
- Basic role-based use (Admin / Employee) depending on the database data

## Tech Stack

- C# (.NET, Windows Forms)
- MySQL
- Visual Studio

## How to run

```bash
1. Clone the project

   git clone https://github.com/mhelail/CalisanTakipSistemi.git
   cd CalisanTakipSistemi

2. Create the database in MySQL

   - Create a database named CalisanTakipDB
   - Run the SQL scripts that create:
     - Tables (Users, Employees, Attendance, AuditLogs)
     - Stored procedures (for Users, Employees, Attendance, AuditLogs)
     - Triggers (for attendance checks and logging)
   - The SQL code is the same as the one I used in my report for this project.

3. Open the solution in Visual Studio

   - Open WinFormsApp1.sln

4. Update the connection string

   - Open App.config
   - Set your own:
     - server
     - user id
     - password
     - database (should be CalisanTakipDB)

5. Build and run

   - Build the project in Visual Studio
   - Run the application
