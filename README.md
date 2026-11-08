<div align="center">

# COME_373_WebProgramming_Proje

### ASP.NET Core E-Commerce Demo

A small, layered e-commerce web application built with ASP.NET Core MVC. Browse and filter products, manage a session-based shopping cart, and submit shipping details to complete an order.

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/aspnet/core/)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-9.0-512BD4?logo=nuget&logoColor=white)](https://learn.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)

</div>

---

## Project overview

This project demonstrates a classic server-rendered e-commerce flow using ASP.NET Core MVC and a layered C# solution. Product and category data is accessed through service and repository abstractions, while cart contents are stored in the user's session.

## Features

- Browse products with category filtering
- Paginate product listings
- Add products to the cart and adjust quantities
- Keep cart contents in session between requests
- Enter shipping details and submit an order
- Separate UI, business logic, data access, and entity projects
- Use Entity Framework Core with SQL Server

## Technology

| Area | Tools |
| --- | --- |
| Language | C# |
| Web application | ASP.NET Core MVC, .NET 8 |
| Data access | Entity Framework Core, repository pattern |
| Database | SQL Server LocalDB by default |
| Validation | FluentValidation |
| Front-end assets | Bootstrap, jQuery |

## Architecture

The solution separates responsibilities across projects:

```text
MvcWebUI
    → Business
    → DataAccess
    → Core / Entities
    → SQL Server
```

- **MvcWebUI** — MVC controllers, Razor views, view models, and session helpers
- **Business** — product, category, cart, and shipping-detail services
- **DataAccess** — Entity Framework repositories and database context
- **Core** — shared repository and entity abstractions
- **Entities** — product, category, shipping, and cart domain models

## Run locally

### Requirements

- .NET 8 SDK
- SQL Server LocalDB (the default connection is configured in the data context)
- Visual Studio 2022 or the .NET CLI

### Start the application

Clone the repository and run the MVC project:

```bash
git clone https://github.com/enesozturk0/COME_373_WebProgramming_Proje.git
cd COME_373_WebProgramming_Proje
dotnet run --project MvcWebUI/MvcWebUI.csproj
```

The application uses the launch profile configured for the MVC project. Open the local URL printed in the terminal.

### Database configuration

The current Entity Framework context uses a SQL Server LocalDB connection named `EticaretDemo`. Ensure LocalDB is installed and available. To use a different SQL Server instance, update the connection in:

`DataAccess/Concrete/EntityFramework/Contexts/EticaretDemoContext.cs`

## Main user flow

1. Open the product catalog.
2. Browse all products or filter by category.
3. Add items to the cart; adding an existing item increases its quantity.
4. Review the cart and provide shipping details.
5. Submit the order to save the shipping details and clear the cart.

## Repository structure

```text
.
├── Business/       # Application services and business logic
├── Core/           # Shared data access and entity abstractions
├── DataAccess/     # EF Core repositories and SQL Server context
├── Entities/       # Domain entities and cart models
├── MvcWebUI/       # ASP.NET Core MVC application
└── ETicaretDemo.sln
```

## License

No license is currently specified in this repository.
