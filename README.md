# Screen Sound Backend

Screen Sound is a simple C# console application that allows users to manage and evaluate music bands. It provides an interactive command-line interface to register bands, view all registered bands, add evaluations (ratings), and calculate the average rating for a specific band.

## Features

- **Register a band:** Add new bands to the system.
- **Register an album:** Add a new album to the system.
- **Show band discography:** Display a band's discography, including albums and their average ratings.
- **Evaluate a band:** Add a numeric rating to a specific band.
- **Evaluate an album:** Add a numeric rating to a specific album.
- **Show bands with average evaluation:** Calculate and display the average rating for a band based.

## Technologies Used

- C#
- .NET 8.0

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) must be installed on your machine.

### Configuration & Environment Variables

- `GEMINI_API_KEY`: API key for Gemini AI.
- `ENABLE_GEMINI`: Flag to enable or disable Gemini AI.

To set the environment variables, create a `.env` file in the project root directory and add the following lines:

```bash
GEMINI_API_KEY=your_api_key_here
ENABLE_GEMINI=true
```

> [!IMPORTANT]
> If `ENABLE_GEMINI` is set to `false` or `GEMINI_API_KEY` is not set, the AI features will be disabled.

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
2. Register an album
3. Show band discography
4. Evaluate a band
5. Evaluate a album
6. Show bands with average evaluation
0. Exit
```

Simply type the number corresponding to the action you want to perform and press `Enter`. Follow the on-screen prompts to input data such as band names and evaluation scores.

## Project Structure

- `Program.cs`: Contains the main logic of the application, including the menu system and band management functions.
- `screenSoundBackend.csproj`: The C# project file defining the target framework (.NET 8.0).
