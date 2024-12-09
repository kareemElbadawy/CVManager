# CV Manager API

## Description

The CV Manager API is designed to manage CV (Curriculum Vitae) information efficiently. It follows the Onion Architecture, which promotes a clean separation of concerns, maintainability, and testability. This API provides endpoints to create, read, update, and delete CVs along with associated personal and experience information.

## Table of Contents

1. [Architecture](#architecture)
2. [Installation](#installation)
3. [Usage](#usage)
   - [API Endpoints](#api-endpoints)
   - [Example Requests](#example-requests)
   - [Example Responses](#example-responses)
4. [Contributing](#contributing)
5. [License](#license)
6. [Contact](#contact)

## Architecture

This project follows the Onion Architecture pattern which includes the following layers:

1. **Core**: Contains the domain entities and domain logic.
2. **Application**: Handles the application logic and coordinates the domain.
3. **Infrastructure**: Provides technical capabilities like data access, messaging, etc.
4. **API**: The entry point for the application, exposing the endpoints for interaction.

### Layers and Dependencies

- **Core Layer**: Independent of any other layer.
- **Application Layer**: Depends on the Core Layer.
- **Infrastructure Layer**: Depends on the Application Layer and Core Layer.
- **API Layer**: Depends on all other layers.

## Installation

### Prerequisites

- Node.js and npm installed on your machine.
- MongoDB or any other database if required.
- Angular CLI for the front-end application.

### Installing

1. **Clone the repository**:
   ```bash
   git clone https://github.com/kareemElbadawy/CVManager-Api.git
   cd CVManager-Api
Install dependencies:

bash
npm install
Set up environment variables: Create a .env file in the root directory and add the following variables:

env
DATABASE_URL=mongodb://localhost:27017/cv-manager
PORT=3000
Start the server:

bash
npm start
Usage
API Endpoints
Create a CV
URL: /api/cvs

Method: POST

Request Body:

json
{
  "name": "John Doe",
  "personalInformation": {
    "fullName": "John Doe",
    "cityName": "New York",
    "email": "john.doe@example.com",
    "mobileNumber": "1234567890"
  },
  "experienceInformation": {
    "companyName": "TechCorp",
    "city": "New York",
    "companyField": "Software Development"
  }
}
Response:

json
{
  "id": 1,
  "name": "John Doe",
  "personalInformation": {
    "fullName": "John Doe",
    "cityName": "New York",
    "email": "john.doe@example.com",
    "mobileNumber": "1234567890"
  },
  "experienceInformation": {
    "companyName": "TechCorp",
    "city": "New York",
    "companyField": "Software Development"
  }
}
Get All CVs
URL: /api/cvs

Method: GET

Response:

json
[
  {
    "id": 1,
    "name": "John Doe",
    "personalInformation": {
      "fullName": "John Doe",
      "cityName": "New York",
      "email": "john.doe@example.com",
      "mobileNumber": "1234567890"
    },
    "experienceInformation": {
      "companyName": "TechCorp",
      "city": "New York",
      "companyField": "Software Development"
    }
  },
  // More CVs...
]
Get a Single CV
URL: /api/cvs/:id

Method: GET

Response:

json
{
  "id": 1,
  "name": "John Doe",
  "personalInformation": {
    "fullName": "John Doe",
    "cityName": "New York",
    "email": "john.doe@example.com",
    "mobileNumber": "1234567890"
  },
  "experienceInformation": {
    "companyName": "TechCorp",
    "city": "New York",
    "companyField": "Software Development"
  }
}
Update a CV
URL: /api/cvs/:id

Method: PUT

Request Body:

json
{
  "name": "Jane Doe",
  "personalInformation": {
    "fullName": "Jane Doe",
    "cityName": "San Francisco",
    "email": "jane.doe@example.com",
    "mobileNumber": "0987654321"
  },
  "experienceInformation": {
    "companyName": "WebSolutions",
    "city": "San Francisco",
    "companyField": "Web Development"
  }
}
Response:

json
{
  "id": 1,
  "name": "Jane Doe",
  "personalInformation": {
    "fullName": "Jane Doe",
    "cityName": "San Francisco",
    "email": "jane.doe@example.com",
    "mobileNumber": "0987654321"
  },
  "experienceInformation": {
    "companyName": "WebSolutions",
    "city": "San Francisco",
    "companyField": "Web Development"
  }
}
Delete a CV
URL: /api/cvs/:id

Method: DELETE

Response:

json
{
  "message": "CV deleted successfully"
}
Contributing
Fork the repository.

Create your feature branch: git checkout -b feature/my-new-feature.

Commit your changes: git commit -m 'Add some feature'.

Push to the branch: git push origin feature/my-new-feature.

Submit a pull request.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any inquiries, you can reach us at:

Email: support@cvmanager.com

Website: CV Manager

GitHub: CV Manager GitHub


Feel free to customize further based on your project's specific needs or preferences! If you need any additional sections or changes, just let me know.
