using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Builders;

internal class BandBuilder
{
    private readonly string _name;
    private readonly List<Album> _albums = [];
    private readonly List<Evaluate> _evaluations = [];

    public BandBuilder(string name)
    {
        _name = name;
    }

    public BandBuilder WithAlbum(Album album)
    {
        _albums.Add(album);
        return this;
    }

    public BandBuilder WithAlbum(string albumName)
    {
        _albums.Add(new Album(albumName));
        return this;
    }

    public BandBuilder WithEvaluation(Evaluate evaluation)
    {
        _evaluations.Add(evaluation);
        return this;
    }

    public BandBuilder WithEvaluation(int score)
    {
        _evaluations.Add(new Evaluate(score));
        return this;
    }

    public Band Build()
    {
        Band band = new(_name);
        foreach (var album in _albums)
        {
            band.AddAlbum(album);
        }
        foreach (var evaluation in _evaluations)
        {
            band.AddEvaluation(evaluation);
        }
        return band;
    }
}
