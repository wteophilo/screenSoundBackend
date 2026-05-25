namespace ScreenSoundBackend.Models;

internal class Evaluate(int score)
{
    public int Score { get; } = score;

    public static Evaluate Parse(string text)
    {
        return new Evaluate(int.Parse(text));
    }
}