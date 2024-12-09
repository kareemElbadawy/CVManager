# CVManager API

This repository contains the backend API for **CVManager** system, which allows users to create, manage, and update CVs. The application is built using **.NET Core** and follows the **Onion Architecture** for better maintainability and separation of concerns.

## Table of Contents
- [Project Overview](#project-overview)
- [Technologies](#technologies)
- [Setup Instructions](#setup-instructions)
- [Directory Structure](#directory-structure)
- [API Endpoints](#api-endpoints)
- [Authentication](#authentication)
- [Error Handling](#error-handling)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Project Overview

The **CVManager API** provides endpoints for managing CV data. It is part of the **CVManager System**, which helps users create, store, and update personal CVs. The API exposes RESTful endpoints for managing entities like personal information, experience information, and CV details.

## Technologies

- **.NET 6.0** (or latest stable version)
- **Onion Architecture**: The project is organized into several layers:
  - **Core**: Contains domain models and interfaces.
  - **Application**: Contains application logic and services.
  - **Infrastructure**: Contains implementations for data access and external services.
  - **API**: Contains the API controllers and endpoints.
- **Entity Framework Core**: For interacting with the database.
- **Swagger**: For API documentation and testing.
- **Automapper**: For object-to-object mapping.
- **MediatR**: For implementing the CQRS pattern.
- **JWT**: For authentication and authorization.

## Setup Instructions

### Prerequisites
- Install **.NET 6.0 SDK** (or the appropriate version if using a different version).
- Install **SQL Server** or **SQL Server Express** for the database.
- You may also use **Docker** to run the database container.

### Clone the Repository
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/kareemElbadawy/CVManager-Api.git
   cd CVManager-Api
Configure Database Connection
Open appsettings.json and configure your database connection string under the ConnectionStrings section.

Example for SQL Server:

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CVManagerDb;User Id=sa;Password=yourpassword;"
}
Alternatively, you can configure the connection string through environment variables for added security.

Apply Migrations
Run the following command to apply migrations to the database:
bash
Copy code
dotnet ef database update
Run the Application
Build and run the application:

bash
Copy code
dotnet run
The API will be available at https://localhost:5001 (default, can be configured in launchSettings.json).

To verify, open your browser and navigate to:

API Documentation: https://localhost:5001/swagger
Health Check Endpoint: https://localhost:5001/api/health
Directory Structure
bash
Copy code
CVManager-Api
├── Core
│   ├── Entities
│   ├── Interfaces
│   └── ValueObjects
├── Application
│   ├── DTOs
│   ├── Interfaces
│   └── Services
├── Infrastructure
│   ├── Data
│   ├── Repositories
│   └── Services
└── API
    ├── Controllers
    ├── Filters
    └── Helpers
Core
Contains business logic, domain models, and interfaces for repositories and services.
Application
Contains application logic, such as use cases and service implementations.
Infrastructure
Contains implementation details such as database contexts, migrations, and external service integrations.
API
Contains controllers, routes, middleware, and other HTTP-related logic.
API Endpoints
CV Endpoints
Create CV
POST /api/cv
Request body:
json
Copy code
{
  "name": "John Doe",
  "personalInformation": { ... },
  "experienceInformation": { ... }
}
Response:
json
Copy code
{
  "id": 1,
  "name": "John Doe",
  "personalInformation": { ... },
  "experienceInformation": { ... }
}
Update CV
PUT /api/cv/{id}
Request body:
json
Copy code
{
  "id": 1,
  "name": "Jane Doe",
  "personalInformation": { ... },
  "experienceInformation": { ... }
}
Response:
json
Copy code
{
  "message": "CV updated successfully."
}
Get CV by ID
GET /api/cv/{id}
Response:
json
Copy code
{
  "id": 1,
  "name": "John Doe",
  "personalInformation": { ... },
  "experienceInformation": { ... }
}
Delete CV
DELETE /api/cv/{id}
Response:
json
Copy code
{
  "message": "CV deleted successfully."
}
Health Check
GET /api/health
Response:
json
Copy code
{
  "status": "Healthy"
}
Authentication
This API uses JWT tokens for authentication.
To authenticate, pass the Authorization header with the value Bearer <token> in your requests.
Example:
bash
Copy code
curl -X GET https://localhost:5001/api/cv -H "Authorization: Bearer <token>"
Error Handling
The API uses standard HTTP status codes to indicate the result of API requests.

200 OK: The request was successful.
201 Created: A resource was successfully created.
400 Bad Request: The request was invalid.
401 Unauthorized: The user is not authenticated or authorized.
404 Not Found: The requested resource was not found.
500 Internal Server Error: An error occurred on the server.