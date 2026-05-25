// See https://aka.ms/new-console-template for more information

using ScreenSoundBackend.Models;

string welcome = "Welcome to Screen Sound";
string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";


Band oneOkRock = new("One Ok Rock");
oneOkRock.AddEvaluation(new Evaluate(10));
oneOkRock.AddEvaluation(new Evaluate(9));
oneOkRock.AddEvaluation(new Evaluate(8));

Band linkinPark = new("Linkin Park");
linkinPark.AddEvaluation(new Evaluate(10));
linkinPark.AddEvaluation(new Evaluate(9));
linkinPark.AddEvaluation(new Evaluate(8));

Dictionary<string, Band> bands = new()
{
    { oneOkRock.Name, oneOkRock },
    { linkinPark.Name, linkinPark }
};

void showWelcomeMessage()
{
    Console.WriteLine(logo);
    Console.WriteLine(welcome);
}

void showOptions()
{
    Console.WriteLine("\nAvailable options:");
    Console.WriteLine("1. Register a band");
    Console.WriteLine("2. Show all bands");
    Console.WriteLine("3. Register an album");
    Console.WriteLine("4. Evaluate a band");
    Console.WriteLine("5. Show bands with average evaluation");
    Console.WriteLine("0. Exit");
}

int readOption()
{
    Console.Write("\nChoose an option: ");
    int option = int.Parse(Console.ReadLine()!);
    return option;
}

void handleOption(int option)
{
    switch (option)
    {
        case 1:
            registerBand();
            break;
        case 2:
            showAllBands();
            break;
        case 3:
            registerAlbum();
            break;
        case 4:
            evaluateBand();
            break;
        case 5:
            averageEvaluationByBand();
            break;
        case 0:
            Console.WriteLine("Thanks for using Screen Sound =)");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void registerBand()
{
    string title = "Register a band";
    showPageTitle(title);
    Console.Write("What band do you want do add: ");
    string bandName = Console.ReadLine()!;
    Band newBand = new(bandName);
    bands.Add(bandName, newBand);
    Console.WriteLine($"{bandName} was registered successfully!");
    Thread.Sleep(2000);
    backToMainMenu();
}

void showAllBands()
{
    string title = "Show all bands";
    showPageTitle(title);
    foreach (string band in bands.Keys)
    {
        Console.WriteLine(band);
    }
    Thread.Sleep(2000);
    backToMainMenu();
}

void registerAlbum()
{
    string title = "Register an album";
    showPageTitle(title);
    Console.Write("What album do you want do add: ");
    string albumName = Console.ReadLine()!;

    Console.Write("What band do you want do add album to: ");
    string bandName = Console.ReadLine()!;
    if (bands.TryGetValue(bandName, out Band? foundedBand))
    {
        Album newAlbum = new(albumName);
        foundedBand.AddAlbum(newAlbum);
        Console.WriteLine($"{albumName} was registered successfully!");
    }
    else
    {
        Console.WriteLine($"Band {bandName} not found.");
    }
    Thread.Sleep(2000);
    backToMainMenu();
}

void evaluateBand()
{
    string title = "Evaluate a band";
    showPageTitle(title);
    Console.Write("What band do you want to evaluate: ");
    string bandName = Console.ReadLine()!;
    if (bands.TryGetValue(bandName, out Band? foundedBand))
    {
        Console.Write("Enter your evaluation (1-10): ");
        int evaluation = int.Parse(Console.ReadLine()!);
        foundedBand.AddEvaluation(new Evaluate(evaluation));
        Console.WriteLine($"Evaluation added to {bandName}!");
    }
    else
    {
        Console.WriteLine($"Band {bandName} not found.");
    }
    Thread.Sleep(2000);
    backToMainMenu();
}

void averageEvaluationByBand()
{
    string title = "Average Evaluation By Band";
    showPageTitle(title);

    Console.Write("What band do you want to evaluate: ");
    string bandName = Console.ReadLine()!;

    if (bands.TryGetValue(bandName, out Band? foundedBand))
    {
        if (!foundedBand.HasEvaluations())
        {
            Console.WriteLine("This band has no evaluations.");
            return;
        }

        Console.WriteLine($"The average evaluation of {bandName} is {foundedBand.Average}.");
    }
    else
    {
        Console.WriteLine($"Band {bandName} not found.");
    }
    Thread.Sleep(2000);
    backToMainMenu();
}

void backToMainMenu()
{
    Console.WriteLine("Press Enter to go back to main menu");
    Console.ReadLine();
    Console.Clear();
    main();
}

void showPageTitle(string title)
{
    string line = string.Empty.PadLeft(title.Length, '=');
    Console.WriteLine(line);
    Console.WriteLine(title);
    Console.WriteLine(line + "\n");
}

void main()
{
    showWelcomeMessage();
    showOptions();
    int option = readOption();
    handleOption(option);
}

main();
