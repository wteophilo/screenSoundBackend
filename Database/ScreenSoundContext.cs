using Microsoft.EntityFrameworkCore;
using ScreenSoundBackend.Models;

namespace ScreenSoundBackend.Database;

internal class ScreenSoundContext : DbContext
{
    private readonly string connectionString;
    public DbSet<Band> Bands { get; set; } = null!;
    public DbSet<Album> Albums { get; set; } = null!;
    public DbSet<Music> Musics { get; set; } = null!;

    public ScreenSoundContext()
    {
        var envConnection = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
        this.connectionString = !string.IsNullOrEmpty(envConnection)
            ? envConnection
            : "Server=localhost;Port=3306;Database=ScreenSound;Uid=ScreenSound;Pwd=YourStrongPassword123;AllowPublicKeyRetrieval=True;";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .UseLazyLoadingProxies();
    }
}