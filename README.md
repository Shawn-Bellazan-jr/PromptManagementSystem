## Prompt Management System - A .NET Core Web Application for Prompt Management

This repository contains the source code for Prompt Management System, a web application built using C# and .NET Core for managing prompts. The application allows users to create, read, update, and delete prompts, categorized by type or other relevant criteria.

### Features:

- **CRUD operations:** Create, read, update, and delete prompts using a user-friendly interface.
- **Categorization:** Organize prompts into categories for easier retrieval and navigation.
- **Clean architecture:** Follows the principles of clean architecture, separating concerns into distinct layers for enhanced testability and maintainability.
- **Data persistence:** Uses SQL Server as the backend database for storing and managing prompts.
- **Security:** Implements authentication and authorization mechanisms for secure access to the application.
- **Unit testing:** Includes comprehensive unit tests to ensure code quality and functionality.

### Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/PromptManagementSystem.git
   ```

2. **Install dependencies:**
   ```bash
   cd PromptManagementSystem
   dotnet restore
   ```

3. **Configure database:**
   - Create a new SQL Server database and configure the connection string in the `appsettings.json` file.

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Access the application:**
   - The application will be accessible at `http://localhost:5000` (or a different port if specified).

### Technologies Used:

- **C# and .NET Core:** The core programming language and framework for building the application.
- **ASP.NET Core:** For building the web application and handling user requests.
- **ASP.NET Core Razor Pages:** For creating view components and handling user input.
- **Entity Framework Core:** The ORM for interacting with the SQL Server database.
- **Dapper:** Optional, for optimized SQL interaction if needed.
- **xUnit/NUnit:** Unit testing framework.
- **Dependency Injection:** Built-in .NET Core DI Container for managing dependencies.

### Architecture Overview

The application follows a clean architecture pattern with the following layers:

- **Presentation:** Handles user interactions and UI.
- **Application:** Defines business logic and orchestrates operations between other layers.
- **Domain:** Contains core business rules, entities, and logic.
- **Infrastructure:** Provides access to external resources like databases.

### Contribution

Contributions to this project are welcome! Please create a new issue or pull request for any improvements or bug fixes.

### License

This project is licensed under the MIT License. See the `LICENSE` file for more details.


