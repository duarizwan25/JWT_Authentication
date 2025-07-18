# AuthWebAPI

A cleanly-structured ASP.NET Core Web API implementing **JWT Authentication** using **.NET 8**, **Entity Framework Core**, and **Clean Architecture** principles.

---

## Folders & Files

| Path                | Description                                                                 |
|---------------------|-----------------------------------------------------------------------------|
| `Controllers/`       | API controllers – entry points to handle HTTP requests                     |
| `Services/`          | Business logic – includes implementations like `AuthService`               |
| `Data/`              | Database context setup using Entity Framework Core (`MyDbContext`)         |
| `Models/`            | DTOs and Entity Models for request/response mapping and persistence         |
| `Program.cs`         | Application bootstrap – configures DI, middleware, JWT auth, Swagger, etc. |
| `appsettings.json`   | Contains configuration (DB connection string, JWT settings, etc.)          |
| `AuthWebAPI.csproj`  | .NET project configuration file                                             |

This structure ensures a **clear separation of concerns**, enabling better maintainability and scalability.
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
