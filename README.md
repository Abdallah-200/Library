Library Management System ASP.NET Core MVC (Skeleton)
----------------------------------------------------
What this contains:
- Minimal ASP.NET Core MVC project structure for a library system
- Models: Book, Author, Category, Borrower, BorrowRecord
- Data: ApplicationDbContext using EF Core
- Controllers: BooksController, AuthorsController, CategoriesController, BorrowersController, DashboardController (skeletons)
- Views: minimal Razor views (Index pages)
- appsettings.json with placeholder connection string
- README with run instructions

How to run:
1. Install .NET SDK (7.0 or later recommended).
2. Open a terminal in the project folder.
3. Run: dotnet restore
4. Run migrations (optional): dotnet ef migrations add Init && dotnet ef database update
   (You may need to install EF tools: dotnet tool install --global dotnet-ef)
5. Run: dotnet run
6. Open browser at https://localhost:5001 or as indicated.

Notes:
- This is a starter skeleton. You will need to add Identity, UI polishing, and reports/graphs.
- Static files (wwwroot) include placeholders.
