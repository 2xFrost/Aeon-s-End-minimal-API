namespace AeonsEndApi.Data.DBAccess;

public class DataContext : DbContext
{
    public DbSet<Card> Cards { get; set; }

    public DbSet<CardType> CardTypes { get; set; }
    public DbSet<GameVersion> GameVersions { get; set; }
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<Nemezis> Nemeses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SQLServer"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardType>().ToTable("CardTypes");
        modelBuilder.Entity<Card>().ToTable("Cards");
        modelBuilder.Entity<GameVersion>().ToTable("GameVersions");
        modelBuilder.Entity<Hero>().ToTable("Heroes");
        modelBuilder.Entity<Nemezis>().ToTable("Nemeses");
    }
}
