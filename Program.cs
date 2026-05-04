// See https://aka.ms/new-console-template for more information

string welcome = "Welcome to Screen Sound";
string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";

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
            Console.WriteLine("Option selected: " + option);
            break;
        case 2:
            Console.WriteLine("Option selected: " + option);
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

void main() {
    showWelcomeMessage();
    showOptions();
    int option = readOption();
    handleOption(option);
}

main();
