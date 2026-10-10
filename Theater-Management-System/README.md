# Theater Management System

A C# Windows Forms based Theater Management System developed as a database-driven desktop application for managing users, movies, shows, and ticket bookings.

## Features

- User Login and Sign Up
- Role-based access for Admin and User
- Admin Dashboard
- User Management
- Movie Management
- Movie Search
- Movie Details
- Show Time Management
- Ticket Booking
- Total Ticket Price Calculation
- SQL Server Database Integration

## Technologies Used

- **Programming Language:** C#
- **GUI:** Windows Forms
- **Framework:** .NET Framework 4.7.2
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio
- **Database Management:** SQL Server Management Studio (SSMS)

## Application Screenshots

### 1. Admin Login

![Admin Login](screenshot/admin-login.png)

### 2. Admin Dashboard

![Admin Dashboard](screenshot/admin-dashboard.png)

### 3. Show Time Management

![Show Time Management](screenshot/show-time.png)

### 4. User Management

![User Management](screenshot/user-management.png)

### 5. User Login

![User Login](screenshot/user-login.png)

### 6. User Dashboard

![User Dashboard](screenshot/user-dashboard.png)

### 7. Booked Ticket

![Booked Ticket](screenshot/booked-ticket.png)

## Project Structure

```text
Theater Management/
│
├── Database/
│   └── setup.sql
│
├── screenshot/
│   ├── admin-login.png
│   ├── admin-dashboard.png
│   ├── show-time.png
│   ├── user-management.png
│   ├── user-login.png
│   ├── user-dashboard.png
│   └── booked-ticket.png
│
├── Theater Management/
│   ├── FormLogin.cs
│   ├── FormUser.cs
│   ├── FormAdminDashboard.cs
│   ├── DataAccess.cs
│   ├── Program.cs
│   ├── App.config
│   ├── Properties/
│   └── Resources/
│
├── Theater Management.slnx
└── README.md
```

*Note: The project structure is illustrative. Actual filenames and folders may vary.*

## Database Setup

1. Open **SQL Server Management Studio (SSMS)**.
2. Open the `Database/setup.sql` file.
3. Execute the script to create the required database and tables.
4. Make sure SQL Server or SQL Server Express is installed and running.
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

> These demo credentials are intended for testing and will work only if they are configured in the database setup.

## Running the Project

### 1. Clone the Repository

Replace `YOUR-USERNAME` with your GitHub username.

```bash
git clone https://github.com/YOUR-USERNAME/theater-management.git
```

### 2. Open the Project

Open `Theater Management.slnx` in Visual Studio.

### 3. Set Up the Database

Execute the `Database/setup.sql` script in SQL Server Management Studio.

### 4. Configure the Connection String

Check the connection string in `App.config` and update the SQL Server instance name if necessary.

### 5. Build the Solution

Build the solution in Visual Studio.

### 6. Run the Application

Run the application from Visual Studio.

## Git Ignore

The following Visual Studio generated files and folders should be excluded from version control:

```gitignore
.vs/
bin/
obj/
*.user
*.suo
```

These entries should be saved in a `.gitignore` file in the root directory of the repository. These files are generated automatically by Visual Studio and are generally not required to run the project from source.

## Project Purpose

This project was developed as an academic C# and database project to demonstrate desktop application development, Windows Forms, SQL Server integration, CRUD operations, authentication, role-based access, and database-driven application design.

## Author

**Ibn Abir Hossan Hemel**  
American International University-Bangladesh (AIUB)

---

⭐ If you find this project useful, feel free to explore the source code.