# Library Management System

![Library Management System Logo](./LibraryManagementSystem/LibraryManagementSystem/Assets/library_logo.png)

## Introduction

The Library Management System is a comprehensive C# desktop application designed to streamline library operations. It provides an efficient solution for managing book inventory, handling lending and return processes, and maintaining a digital catalog of library resources. Built with a focus on user experience, this system helps library staff perform their daily tasks with improved efficiency and accuracy.

## Project Overview

This application is developed using C# and Windows Forms, featuring a modern, intuitive interface that simplifies complex library management tasks. The system integrates with Microsoft SQL Server for robust data storage and retrieval, ensuring that library information is securely maintained and easily accessible when needed.

## Key Features

- **Book Management**: Add, edit, delete, and categorize books in the library inventory
- **Lending Operations**: Issue books to readers and track due dates with automated notifications
- **Return Processing**: Record returned books and monitor late returns
- **Dashboard Analytics**: View real-time statistics on available books, currently borrowed books, and return rates
- **Book Classification**: Organize and filter books by genres, authors, and publication dates
- **User Administration**: Manage system access with role-based permissions
- **Visual Interface**: Upload and display book cover images for visual identification

## Screenshots

### Login Screen
![Login Screen](./screenshots/login_screen.png)

### Main Menu
![Main Menu](./screenshots/main_menu.png)

### Dashboard
![Dashboard](./screenshots/dashboard.png)

### Add Books
![Add Books](./screenshots/add_books.png)

### Issue Books
![Issue Books](./screenshots/issue_books.png)

### Return Books
![Return Books](./screenshots/return_books.png)

## Demo Video

[![Library Management System Demo Video](./screenshots/video_thumbnail.png)](https://www.youtube.com/watch?v=your_video_id)

## Technical Specifications

### Development Stack
- **Programming Language**: C#
- **User Interface**: Windows Forms
- **Database**: Microsoft SQL Server
- **Development Environment**: Visual Studio

### System Requirements
- **Operating System**: Windows 7 or higher
- **Framework**: .NET Framework 4.7.2 or higher
- **Database**: Microsoft SQL Server 2014 or higher
- **Memory**: Minimum 2GB RAM
- **Storage**: Minimum 100MB free disk space

## Database Architecture

The system utilizes Microsoft SQL Server for data management. The database consists of the following tables:

### 1. Books Table
- **id**: Auto-incrementing primary key
- **book_title**: Title of the book
- **author**: Author's name
- **published_date**: Publication date
- **status**: Book status (Available, Borrowed)
- **book_type**: Genre or category
- **image**: Path to cover image file
- **date_insert**: Record creation timestamp
- **date_update**: Record update timestamp
- **date_delete**: Soft delete timestamp

### 2. Issues Table
- **id**: Auto-incrementing primary key
- **issue_id**: Lending transaction number
- **full_name**: Borrower's full name
- **contact**: Contact information
- **email**: Email address
- **book_title**: Title of borrowed book
- **book_type**: Genre or category
- **author**: Author's name
- **status**: Status (Borrowed, Returned)
- **issue_date**: Date when book was lent
- **return_date**: Expected return date
- **date_insert**: Record creation timestamp
- **date_update**: Record update timestamp
- **date_delete**: Soft delete timestamp

### 3. Users Table
- **id**: Auto-incrementing primary key
- **username**: System username
- **password**: Securely stored password
- **date_insert**: Record creation timestamp
- **date_update**: Record update timestamp
- **date_delete**: Soft delete timestamp

## Installation Guide

1. Clone the repository from GitHub or download as ZIP.
2. Open Microsoft SQL Server Management Studio.
3. Create a new database named `Library_Management`.
4. Execute the following SQL commands to create the necessary tables:

```sql
-- Books table
CREATE TABLE books (
    id INT PRIMARY KEY IDENTITY(1,1),
    book_title NVARCHAR(100) NOT NULL,
    author NVARCHAR(100) NOT NULL,
    published_date DATE NOT NULL,
    status NVARCHAR(50) NOT NULL,
    book_type NVARCHAR(50) NOT NULL,
    image NVARCHAR(MAX) NOT NULL,
    date_insert DATETIME NOT NULL,
    date_update DATETIME NULL,
    date_delete DATETIME NULL
);

-- Issues table
CREATE TABLE issues (
    id INT PRIMARY KEY IDENTITY(1,1),
    issue_id NVARCHAR(50) NOT NULL,
    full_name NVARCHAR(100) NOT NULL,
    contact NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    book_title NVARCHAR(100) NOT NULL,
    book_type NVARCHAR(50) NOT NULL,
    author NVARCHAR(100) NOT NULL,
    status NVARCHAR(50) NOT NULL,
    issue_date DATE NOT NULL,
    return_date DATE NOT NULL,
    date_insert DATETIME NOT NULL,
    date_update DATETIME NULL,
    date_delete DATETIME NULL
);

-- Users table
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50) NOT NULL,
    password NVARCHAR(100) NOT NULL,
    date_insert DATETIME NOT NULL,
    date_update DATETIME NULL,
    date_delete DATETIME NULL
);

-- Add default admin user
INSERT INTO users (username, password, date_insert)
VALUES ('admin', 'admin123', GETDATE());
```

5. Open the project in Visual Studio.
6. Modify the database connection string in each form to match your SQL Server configuration:

```csharp
private readonly SqlConnection connect = new SqlConnection(@"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True;TrustServerCertificate=True");
```

7. Build and run the project.

## User Guide

1. Launch the application and log in using your username and password.
2. Select the desired operation from the main menu:
   - **Dashboard**: View overall statistics and system status
   - **Add Book**: Register new books in the system
   - **Issue Book**: Lend books to readers
   - **Return Book**: Process book returns
   - **Book Types**: Manage book categories and genres
3. Log out when finished.

## Release Notes

### Version 1.0.0 (April 8, 2025)
- Initial release

## License

This project is licensed under the [MIT License](LICENSE).

## Contact Information

For questions or suggestions:
- Email: gokhakan42@gmail.com
- GitHub: [github.com/justpeder1](https://github.com/justpeder1)