namespace ScreenSoundBackend.Menus;

internal class WelcomeMessage
{
    private const string WELCOME_MESSAGE = "Welcome to Screen Sound";
    private const string LOGO = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";

    public static void ShowWelcomeMessage()
    {
        Console.WriteLine(WELCOME_MESSAGE);
        Console.WriteLine(LOGO);
    }
}