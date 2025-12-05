# Chess

A full-stack chess application built with .NET Core backend and React frontend.

## 📋 Description

This is a modern chess application that provides a complete chess gaming experience. The application features a robust backend API built with .NET Core and a responsive frontend interface built with React and Vite.

## 🚀 Tech Stack

### Backend
- **Framework**: ASP.NET Core
- **Language**: C#
- **Architecture**: Domain-Driven Design (DDD) with Clean Architecture
  - **Domain Layer**: Core business logic and entities
  - **Application Layer**: Business services and use cases
  - **API Layer**: RESTful endpoints and controllers

### Frontend
- **Framework**: React
- **Build Tool**: Vite
- **Routing**: React Router
- **Language**: JavaScript (JSX)

## 📁 Project Structure

```
Chess/
├── ChessBackend/           # Backend .NET Core application
│   ├── ChessBackend.Api/           # API layer with controllers
│   ├── ChessBackend.Application/   # Application layer with services
│   └── ChessBackend.Domain/        # Domain layer with entities
│
├── ChessFrontend/          # Frontend React application
│   ├── src/                        # Source files
│   │   ├── pages/                  # Page components
│   │   ├── App.jsx                 # Main App component
│   │   └── main.jsx                # Entry point
│   └── vite.config.js              # Vite configuration
│
└── README.md               # This file
```

## 🛠️ Setup Instructions

### Prerequisites
- .NET SDK (version 5.0 or higher)
- Node.js (version 14.0 or higher)
- npm or yarn

### Backend Setup

1. Navigate to the backend API directory:
   ```bash
   cd ChessBackend/ChessBackend.Api
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

### Frontend Setup

1. Navigate to the frontend directory:
   ```bash
   cd ChessFrontend
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

## 🎮 Running the Application

### Running the Backend

From the `ChessBackend/ChessBackend.Api` directory:

```bash
dotnet run
```

The API will be available at `https://localhost:5001` (or `http://localhost:5000`)

### Running the Frontend

From the `ChessFrontend` directory:

```bash
npm run dev
```

The application will be available at `http://localhost:5173` (default Vite port)

## 🎯 Features

- Chess game state management
- Move validation and execution
- RESTful API for chess operations
- Interactive React-based user interface
- Routing between home and chess game pages

## 🏗️ Architecture & Design Rules

This project follows **Domain-Driven Design (DDD)** principles with strict design rules:

### Core Principles
- **Separation of Concerns**: Each layer has distinct responsibilities
- **Dependency Rule**: Dependencies flow inward (API → Application → Domain)
- **Domain Layer Independence**: The Domain layer has no external dependencies
- **Business Logic in Domain**: Core chess rules and logic reside in the Domain layer

### Design Rules to Follow
1. **Domain Layer** must remain pure and independent
   - No dependencies on Application or API layers
   - Contains entities, value objects, and domain logic
   - Implements chess game rules and validations

2. **Application Layer** orchestrates business workflows
   - Depends only on Domain layer
   - Contains services and use cases
   - Handles application-specific logic

3. **API Layer** exposes functionality via HTTP
   - Depends on Application and Domain layers
   - Contains controllers and DTOs
   - Handles HTTP concerns (routing, serialization, validation)

All contributions must adhere to these architectural principles and design rules.

## 🌐 API Endpoints

- `GET /api/chess` - Get the current game state
- `POST /api/chess` - Make a move in the chess game

## 📝 License

This project is open source and available for educational purposes.

## 👤 Author

Daniel Fiske

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

---

Made with ❤️ for chess enthusiasts
