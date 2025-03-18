# FinancialTracker
A simple ASP.NET MVC application for tracking financial transactions. This project implements basic CRUD (Create, Read, Update, Delete) operations.

Features

✅ Add new transactions (income/expenses)✅ View a list of transactions✅ Edit transaction details✅ Delete transactions

Technologies Used

ASP.NET MVC

Entity Framework (for database management)

SQL Server (or SQLite, MySQL, depending on setup)

Bootstrap (for UI styling)

jQuery (for frontend interactions)

Installation & Setup

1. Clone the repository:

git clone https://github.com/kfikryw/FinancialTracker.git
cd FinancialTracker

2. Open in Visual Studio

Open FinancialTracker.sln in Visual Studio.

Restore dependencies using:

dotnet restore

3. Database Setup

Update the connection string in appsettings.json.

Run database migrations (if using Entity Framework):

dotnet ef database update

4. Run the Application

dotnet run

Open your browser and go to: http://localhost:5000

Usage

Navigate to the dashboard to view transactions.

Use the add transaction form to insert new records.

Click edit to modify existing transactions.

Click delete to remove transactions.
