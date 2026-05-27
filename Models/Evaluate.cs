namespace ScreenSoundBackend.Models;

internal class Evaluate
{
    public int Score { get; }

    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 10;

    public Evaluate(int score)
    {
        if (score <= 0) score = 0;
        if (score >= 10) score = 10;
        this.Score = score;

    }

    public static Evaluate Parse(string text)
    {
        int score = int.Parse(text);
        if (score < MIN_VALUE || score > MAX_VALUE)
        {
            throw new ArgumentException("Score must be between 0 and 10.");
        }
        return new Evaluate(score);
    }
}