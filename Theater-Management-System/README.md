# Theater Management System

A C# Windows Forms based Theater Management System developed as a database-driven desktop application for managing users, movies, shows, and ticket bookings.

## Features

* User Login and Sign Up
* Role-based access for Admin and User
* Admin Dashboard
* User Management
* Movie Management
* Movie Search
* Movie Details
* Show Time Management
* Ticket Booking
* Total Ticket Price Calculation
* SQL Server Database Integration

## Technologies Used

* **Programming Language:** C#
* **GUI:** Windows Forms
* **Framework:** .NET Framework 4.7.2
* **Database:** Microsoft SQL Server
* **IDE:** Visual Studio
* **Database Management:** SQL Server Management Studio (SSMS)

## Project Structure

```text
Theater Management
│
├── Database
│   └── setup.sql
│
├── Theater Management
│   ├── FormLogin.cs
│   ├── FormUser.cs
│   ├── FormAdminDashboard.cs
│   ├── DataAccess.cs
│   ├── Program.cs
│   ├── App.config
│   ├── Properties
│   └── Resources
│
├── Theater Management.slnx
└── README.md
```

## Database Setup

1. Open **SQL Server Management Studio (SSMS)**.
2. Open the `Database/setup.sql` file.
3. Execute the script to create the required database and tables.
4. Make sure SQL Server / SQL Server Express is installed and running.
5. Open the project in Visual Studio.
6. Check the connection string in `App.config`.
7. Update the SQL Server instance name if necessary.
8. Build and run the project.

## Demo Admin Account

For demonstration purposes:

```text
Username: admin
Password: admin123
```

> The demo credentials are included only for testing the project.

## Running the Project

1. Clone the repository:

```bash
git clone https://github.com/YOUR-USERNAME/theater-management.git
```

2. Open `Theater Management.slnx` in Visual Studio.

3. Make sure the database has been created using `Database/setup.sql`.

4. Check the database connection string.

5. Build the solution.

6. Run the application.

## Git Ignore

The following Visual Studio generated files and folders are excluded from the repository:

```text
.vs/
bin/
obj/
*.user
*.suo
```

These files are generated automatically by Visual Studio and are not required to run the project from source.

## Project Purpose

This project was developed as an academic C# and database project to demonstrate desktop application development, Windows Forms, SQL Server integration, CRUD operations, authentication, role-based access, and database-driven application design.

## Author

Ibn Abir Hossan Hemel
American International University-Bangladesh

---

⭐ If you find this project useful, feel free to explore the source code.
