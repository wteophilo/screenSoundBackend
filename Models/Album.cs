namespace ScreenSoundBackend.Models;

internal class Album(string name) : IEvaluable
{
    private readonly List<Music> musics = [];
    private readonly List<Evaluate> evaluations = [];
    public string Name { get; } = name;
    public int DurationTotal => musics.Sum(m => m.Duration);
    public List<Music> Musics => musics;

    public double Average
    {
        get
        {
            if (evaluations.Count == 0) return 0;
            return evaluations.Average(e => e.Score);
        }
    }

    public void AddEvaluation(Evaluate evaluation)
    {
        this.evaluations.Add(evaluation);
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowMusics()
    {
        Console.WriteLine($"List of songs of the album {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nTo listen to this album in full you need {DurationTotal} seconds.");
    }
}