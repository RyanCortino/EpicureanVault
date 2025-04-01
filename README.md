# **Epicurean Vault**

Welcome to the **Epicurean Vault** repository. This solution is designed to help you manage your recipes efficiently. The solution is structured with a clear separation of concerns following Domain-Driven Design principles and leverages modern technologies for both backend and frontend development.

## Solution Structure

The solution is divided into several key projects:

1. **Backend API**: Built on the principles of Clean Architecture, the backend API is responsible for handling all business logic and data management. It ensures a clean separation between the domain, application, infrastructure, and presentation layers.

2. **React Web Client**: A modern web client built using React. It provides an intuitive and responsive user interface for managing your recipes from any device with a web browser.

3. **WinForms Desktop Client**: A traditional desktop application built with WinForms. It offers a rich user interface for users who prefer a desktop environment for managing their recipes.

4. **Dotnet Aspire**: The solution is tied together using Dotnet Aspire as an entry point. This ensures a seamless integration between the different components of the solution, providing a unified experience for the user.

## Getting Started

To get started with the **Epicurean Vault**, follow these steps:

### Prerequisites

- .NET SDK 6.0 or later
- Node.js and npm (for the React front-end)
- Visual Studio 2022 or later (recommended) or Visual Studio Code

### Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/EpicureanVault.git
   cd EpicureanVault
   ```

2. **Restore dependencies and build the solution**:
   ```bash
   dotnet restore
   dotnet build
   ```

3. **Run the Backend API**:
   ```bash
   cd src/Web
   dotnet run
   ```

5. **Run the WinForms desktop client**:
   Open the solution in Visual Studio and locate the WinForms project. Then, run the project.

## Project Structure

The repository is organized as follows:

```
recipe-management-software/
├── src/
│   ├── Application/
│   ├── Domain/
│   ├── Infrastructure/
│   └── Web/
├── tests/
│   ├── Application.FunctionalTests/
│   ├── Application.UnitTests/
│   ├── Domain.UnitTests/
│   ├── Infrastructure.IntegrationTests/
│   └── Web.AcceptanceTests/
└── README.md
```

- **src**: Contains the source code for the backend, web client, desktop client, and entry point projects.
- **tests**: Contains the test projects for each component of the solution.

## Contributing

Contributions are welcome! If you have any suggestions or improvements, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements

- Jason Taylor's CleanArchitecture project template for providing a solid foundation for the backend API.
- The Dotnet Aspire team for their work on resource integration.

Happy cooking!