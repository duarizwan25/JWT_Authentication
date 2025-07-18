# AuthWebAPI

A cleanly-structured ASP.NET Core Web API implementing **JWT Authentication** using **.NET 8**, **Entity Framework Core**, and **Clean Architecture** principles.

---

## Project Structure (Clean Architecture)
AuthWebAPI/
├── Controllers/         # API controllers (entry point to the application)
├── Services/            # Business logic (e.g., AuthService)
├── Data/                # EF Core DbContext and database configuration
├── Models/              # DTOs and database entity models
├── Program.cs           # Application startup, DI container, middleware setup
├── appsettings.json     # Configuration (DB connection string, JWT secret, etc.)
└── AuthWebAPI.csproj    # Project configuration

---

## JWT Authentication Overview

### Why JWT?
JWT (JSON Web Token) is used for **secure stateless authentication** between client and server. It ensures:
- Scalability (no session storage)
- Integrity (signed tokens)
- Simplicity (encoded in headers)

### JWT Setup Includes:
- Middleware: `AddAuthentication()` and `AddJwtBearer()`
- Settings: Token `Issuer`, `Audience`, `SecretKey` in `appsettings.json`
- Token generation and validation logic in `AuthService`
- Auth controller to login and get token

---

## Technologies Used

| Tech                     | Purpose                           |
|--------------------------|-----------------------------------|
| **.NET 8**               | Web API Framework                 |
| **EF Core (SQL Server)** | ORM for database access           |
| **JWT (System.IdentityModel.Tokens.Jwt)** | Authentication Token |
| **Swashbuckle/Swagger** | API Documentation UI              |
| **Clean Architecture**   | Separation of concerns            |

---

## Features
- Secure login endpoint returning JWT token
- Token-based access control for protected routes
- Swagger UI for API exploration
- Clean folder separation for scalability
- Follows SOLID principles
