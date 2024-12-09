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
