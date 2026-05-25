namespace ScreenSoundBackend.Models;

internal class Band(string name)
{
    private readonly List<Album> albuns = [];
    private readonly List<Evaluate> evaluations = [];

    public string Name { get; } = name;
    public double Average
    {
        get
        {
            if (evaluations.Count == 0) return 0;
            return evaluations.Average(e => e.Score);
        }
    }
    public List<Album> Albums => albuns;

    public void AddAlbum(Album album)
    {
        this.albuns.Add(album);
    }

    public void AddEvaluation(Evaluate evaluation)
    {
        this.evaluations.Add(evaluation);
    }

    public bool HasEvaluations()
    {
        return this.evaluations.Count > 0;
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Band {this.Name} discography");
        foreach (Album album in this.albuns)
        {
            Console.WriteLine($"Album: {album.Name} ({album.DurationTotal})");
        }
    }

}