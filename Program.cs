// See https://aka.ms/new-console-template for more information

string welcome = "Welcome to Screen Sound";
string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";

Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
bands.Add("One Ok Rock", new List<int>());
bands.Add("System of a Down", new List<int>());
bands.Add("Linkin Park", new List<int>());

void showWelcomeMessage() {
    Console.WriteLine(logo);
    Console.WriteLine(welcome);
}

void showOptions() {
    Console.WriteLine("\nAvailable options:");
    Console.WriteLine("1. Register a band");
    Console.WriteLine("2. Show all bands");
    Console.WriteLine("3. Evaluate a band");
    Console.WriteLine("4. Show bands with average evaluation");
    Console.WriteLine("0. Exit");
}

int readOption() {
    Console.Write("\nChoose an option: ");
    int option = int.Parse(Console.ReadLine()!);
    return option;   
}

void handleOption(int option) {    
    switch(option) {
        case 1:
            registerBand();
            break;
        case 2:
            showAllBands();
            break;
        case 3:
            Console.WriteLine("Option selected: " + option);
            break;
        case 4:
            Console.WriteLine("Option selected: " + option);
            break;
        case 0:
            Console.WriteLine("Thanks for using Screen Sound =)" );
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void registerBand() {
    string title = "Register a band";
    showPageTitle(title);
    Console.Write("What band do you want do add: ");
    string bandName = Console.ReadLine()!;
    bands.Add(bandName, new List<int>());
    Console.WriteLine($"{bandName} was registered successfully!");
    Thread.Sleep(2000);
    backToMainMenu();
}

void showAllBands() {
    string title = "Show all bands";
    showPageTitle(title);
    foreach(string band in bands.Keys) {
        Console.WriteLine(band);
    }
    Thread.Sleep(2000);
    backToMainMenu();
}

void backToMainMenu() {
    Console.WriteLine("Press Enter to go back to main menu");
    Console.ReadLine();
    Console.Clear();
    main();
}

void showPageTitle(string title) {
    string line = string.Empty.PadLeft(title.Length, '=');
    Console.WriteLine(line);
    Console.WriteLine(title);
    Console.WriteLine(line + "\n");
}

void main() {
    showWelcomeMessage();
    showOptions();
    int option = readOption();
    handleOption(option);
}

main();
