# CRUD.Solution – ASP.NET Core MVC Application

This is a full-fledged **CRUD application** built using **ASP.NET Core MVC**, structured with a clean layered architecture. It demonstrates essential backend development practices such as separation of concerns, service-repository pattern, DTO usage, dependency injection, and test-driven development. Ideal for showcasing in a professional portfolio.

---

## 📁 Project Structure

```
CRUD.Solution/
│
├── src/
│   ├── CRUD.Core/             → Domain, DTOs, contracts, helpers
│   ├── CRUD.Infrastructure/  → EF Core DbContext, Repositories, Migrations
│   ├── CRUD.UI/              → ASP.NET MVC web interface (Controllers, Views, Middleware)
│
├── tests/
│   └── CRUD.ServiceTests/    → Unit tests (xUnit + Moq + AutoFixture)
```

---

## 🚀 Features

- Full **CRUD operations** for Person & Country entities
- Authentication via **ASP.NET Identity**
- Server-side validation using **DataAnnotations**
- Clear separation of concerns (Core, Infrastructure, UI)
- Data access with **Entity Framework Core**
- Comprehensive **unit testing** with mocking and assertions
- Structured logging using **Serilog**
- Global error handling via **Middleware**
- Usage of enums for domain logic (e.g., Gender, UserType)

---

## ⚙️ Technologies Used

- ASP.NET Core 8 MVC
- Entity Framework Core 8
- Microsoft Identity
- Serilog
- xUnit, Moq, AutoFixture, FluentAssertions
- MSSQL LocalDB

---

## 🧪 Unit Testing

Unit tests are located under `tests/CRUD.ServiceTests` and cover:

- `CountriesServiceTest.cs`
- `PersonsServiceTest.cs`

Test libraries used:

- xUnit
- Moq
- AutoFixture
- FluentAssertions

To run tests:

```bash
dotnet test
```

---

## 🔧 Configuration

Connection string is located in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CrudDatabase1;Integrated Security=True;"
}
```

Serilog configuration:

```json
"Serilog": {
  "MinimumLevel": "Information",
  "WriteTo": [ { "Name": "Console" } ]
}
```

---

## 🛠️ Getting Started

1. Clone the repository

```bash
git clone https://github.com/batucglyn/CRUD.Solution.git
cd CRUD.Solution
```

2. Restore packages

```bash
dotnet restore
```

3. Apply EF Core migrations

```bash
dotnet ef database update --project src/CRUD.Infrastructure
```

4. Run the application

```bash
dotnet run --project src/CRUD.UI
```

Navigate to: `https://localhost:5001`

---

## 📄 License

This project is open-sourced under the MIT license.

---

## 👨‍💻 Author

**Batuhan Çağlayan**  
GitHub: [https://github.com/batucglyn](https://github.com/batucglyn)

---

## ⭐ Contributions

Feel free to open issues or pull requests for improvements or fixes.