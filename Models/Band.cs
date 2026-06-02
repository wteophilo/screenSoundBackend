namespace ScreenSoundBackend.Models;

internal class Band : IEvaluable
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Summary { get; set; } = string.Empty;

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
    public virtual ICollection<Evaluate> Evaluations { get; set; } = new List<Evaluate>();

    public Band() {}

    public Band(string name)
    {
        Name = name;
    }

    public double Average
    {
        get
        {
            if (Evaluations.Count == 0) return 0;
            return Evaluations.Average(e => e.Score);
        }
    }

    public void AddAlbum(Album album)
    {
        this.Albums.Add(album);
    }

    public void AddEvaluation(Evaluate evaluation)
    {
        this.Evaluations.Add(evaluation);
    }

    public bool HasEvaluations()
    {
        return this.Evaluations.Count > 0;
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"\nAbout the band {this.Summary}\n");
        Console.WriteLine($"{this.Name} discography:");
        foreach (Album album in this.Albums)
        {
            Console.WriteLine($"- {album.Name} -> Average rating: {album.Average}");
        }
    }
}