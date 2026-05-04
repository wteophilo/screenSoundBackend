# Screen Sound Backend

Screen Sound is a simple C# console application that allows users to manage and evaluate music bands. It provides an interactive command-line interface to register bands, view all registered bands, add evaluations (ratings), and calculate the average rating for a specific band.

## Features

- **Register a band:** Add new bands to the system.
- **Show all bands:** Display a list of all currently registered bands.
- **Evaluate a band:** Add a numeric rating to a specific band.
- **Average evaluation:** Calculate and display the average rating for a band based on all its evaluations.

## Technologies Used

- C#
- .NET 8.0

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) must be installed on your machine.

### Running the Application

1. Open your terminal or command prompt.
2. Navigate to the project directory.
3. Run the application using the `dotnet run` command:
   ```bash
   dotnet run
   ```

### Usage

Upon running the application, you will be greeted with a welcome message and a main menu with the following options:

```text
Available options:
1. Register a band
2. Show all bands
3. Evaluate a band
4. Show bands with average evaluation
0. Exit
```

Simply type the number corresponding to the action you want to perform and press `Enter`. Follow the on-screen prompts to input data such as band names and evaluation scores.

## Project Structure

- `Program.cs`: Contains the main logic of the application, including the menu system and band management functions.
- `screenSoundBackend.csproj`: The C# project file defining the target framework (.NET 8.0).
