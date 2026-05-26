using ScreenSoundBackend.Menus;
using ScreenSoundBackend.Models;
using ScreenSoundBackend.Builders;

Band oneOkRock = new BandBuilder("One Ok Rock")
    .WithEvaluation(10)
    .WithEvaluation(9)
    .WithEvaluation(8)
    .WithAlbum("Detox")
    .WithAlbum("Niche Syndrome")
    .Build();

Band linkinPark = new BandBuilder("Linkin Park")
    .WithEvaluation(10)
    .WithEvaluation(9)
    .WithEvaluation(8)
    .Build();


Dictionary<string, Band> bands = new()
{
    { oneOkRock.Name, oneOkRock },
    { linkinPark.Name, linkinPark }
};

Dictionary<int, Menu> menus = new()
{
    {0, new Exit()},
    {1, new RegisterBand()},
    {2, new RegisterAlbum()},
    {3, new ShowBandDiscography()},
    {4, new EvaluateBand()},
    {5, new EvaluateAlbum()},
    {6, new AverageEvaluationByBand()},
};

void handleOption(int option)
{
    if (!menus.ContainsKey(option))
    {
        Console.WriteLine("Invalid option");
    }

    menus[option].Execute(bands);
    if (option > 0) backToMainMenu();
}


void backToMainMenu()
{
    Console.WriteLine("Press Enter to go back to main menu");
    Console.ReadLine();
    Console.Clear();
    main();
}

void main()
{
    WelcomeMessage.ShowWelcomeMessage();
    Menu.ShowOptions();
    int option = Menu.ReadOption();
    handleOption(option);
}

main();
