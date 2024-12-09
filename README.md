
# CVManager API

This repository contains the backend API for **CVManager** system, which allows users to create, manage, and update CVs. The application is built using **.NET Core** and follows the **Onion Architecture** for better maintainability and separation of concerns.

## Table of Contents
- [Project Overview](#project-overview)
- [Technologies](#technologies)
- [Setup Instructions](#setup-instructions)
  - [Configure Database Connection](#configure-database-connection)
  - [Apply Migrations](#apply-migrations)
  - [Run the Application](#run-the-application)
- [Directory Structure](#directory-structure)
- [API Endpoints](#api-endpoints)
- [Error Handling](#error-handling)
- [Contributing](#contributing)
- [License](#license)

## Project Overview

The **CVManager API** provides endpoints for managing CV data. It is part of the **CVManager System**, which helps users create, store, and update personal CVs. The API exposes RESTful endpoints for managing entities like personal information, experience information, and CV details.

## Technologies

- **.NET 5.0** (or latest stable version)
- **Onion Architecture**: The project is organized into several layers:
  - **Core**: Contains domain models and interfaces.
  - **Application**: Contains application logic and services.
  - **Infrastructure**: Contains implementations for data access and external services.
  - **API**: Contains the API controllers and endpoints.
- **Entity Framework Core**: For interacting with the database.
- **Swagger**: For API documentation and testing.
- **Automapper**: For object-to-object mapping.


## Setup Instructions

### Prerequisites
- Install **.NET 5.0 SDK** (or the appropriate version if using a different version).
- Install **SQL Server** or **SQL Server Express** for the database.
- You may also use **Docker** to run the database container.

### Clone the Repository
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/kareemElbadawy/CVManager-Api.git
   cd CVManager-Api
   ```

### Configure Database Connection

1. Open `appsettings.json` and configure your database connection string under the `ConnectionStrings` section.

   Example for SQL Server:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=CVManagerDb;User Id=sa;Password=yourpassword;"
   }
   ```

   You can replace `localhost` with your actual database server address, and update the `Database`, `User Id`, and `Password` fields according to your setup.

2. Alternatively, you can configure the connection string through environment variables for added security.

3. If you're using **Docker**, the connection string can be configured as follows:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=host.docker.internal;Database=CVManagerDb;User Id=sa;Password=yourpassword;"
   }
   ```

### Apply Migrations

1. Run the following command to apply migrations to the database:
   ```bash
   dotnet ef database update
   ```

2. This will create the required database and tables based on your **Entity Framework Core** migrations.

### Run the Application

1. Build and run the application:
   ```bash
   dotnet run
   ```

2. The API will be available at `https://localhost:5001` (default, can be configured in `launchSettings.json`).

3. To verify, open your browser and navigate to:
   - **API Documentation**: `https://localhost:5001/swagger`
   - **Health Check Endpoint**: `https://localhost:5001/api/health`

## Directory Structure

```bash
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
│
└── API
    ├── Controllers
    ├── Filters
    └── Helpers
```

### Core
- Contains business logic, domain models, and interfaces for repositories and services.

### Application
- Contains application logic, such as use cases and service implementations.

### Infrastructure
- Contains implementation details such as database contexts, migrations, and external service integrations.

### API
- Contains controllers, routes, middleware, and other HTTP-related logic.

## API Endpoints

### CV Endpoints

#### Create CV
- **POST** `/api/cvs`
  - Request body: 
    ```json
    {
      "name": "John Doe",
      "personalInformation": { ... },
      "experienceInformation": { ... }
    }
    ```
  - Response: 
    ```json
    {
      "id": 1,
      "name": "John Doe",
      "personalInformation": { ... },
      "experienceInformation": { ... }
    }
    ```

#### Update CV
- **PUT** `/api/cvs/{id}`
  - Request body:
    ```json
    {
      "id": 1,
      "name": "Jane Doe",
      "personalInformation": { ... },
      "experienceInformation": { ... }
    }
    ```
  - Response:
    ```json
    {
      "message": "CV updated successfully."
    }
    ```

#### Get CV by ID
- **GET** `/api/cvs/{id}`
  - Response:
    ```json
    {
      "id": 1,
      "name": "John Doe",
      "personalInformation": { ... },
      "experienceInformation": { ... }
    }
    ```

#### Delete CV
- **DELETE** `/api/cvs/{id}`
  - Response:
    ```json
    {
      "message": "CV deleted successfully."
    }
    ```





## Error Handling

The API uses standard HTTP status codes to indicate the result of API requests.

- **200 OK**: The request was successful.
- **201 Created**: A resource was successfully created.
- **400 Bad Request**: The request was invalid.
- **401 Unauthorized**: The user is not authenticated or authorized.
- **404 Not Found**: The requested resource was not found.
- **500 Internal Server Error**: An error occurred on the server.


## Contributing

We welcome contributions to the **CVManager API** project! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Make your changes and commit them (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a pull request.

Please ensure that your code adheres to the project's coding standards and includes unit tests where necessary.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Thank you for checking out **CVManager API**!
