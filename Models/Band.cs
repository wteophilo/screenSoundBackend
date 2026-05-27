namespace ScreenSoundBackend.Models;

internal class Band(string name) : IEvaluable
{
    private readonly List<Album> albums = [];
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
    public IEnumerable<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        this.albums.Add(album);
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
        Console.WriteLine($"{this.Name} discography:");
        foreach (Album album in this.albums)
        {
            Console.WriteLine($"- {album.Name} -> Average rating: {album.Average}");
        }
    }

}