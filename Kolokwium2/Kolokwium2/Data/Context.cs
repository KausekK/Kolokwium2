using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<backpacks> backpacks { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<CharactersTitles> CharactersTitles { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Titles> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Characters>().HasData(
            new Characters { Id = 1, FirstName = "John", LastName = "Yakuza", CurrentWeight = 43, MaxWeight = 200 }
        );
        
        modelBuilder.Entity<Items>().HasData(
            new Items { Id = 1, Name = "Item1", Weight = 10 },
            new Items { Id = 2, Name = "Item2", Weight = 11 },
            new Items { Id = 3, Name = "Item3", Weight = 12 }
        );

        modelBuilder.Entity<Titles>().HasData(
            new Titles { Id = 1, Name = "Title1" },
            new Titles { Id = 2, Name = "Title2" },
            new Titles { Id = 3, Name = "Title3" }
        );

        modelBuilder.Entity<backpacks>().HasData(
            new backpacks { CharacterId = 1, ItemId = 1, Amount = 2 },
            new backpacks { CharacterId = 1, ItemId = 2, Amount = 1 },
            new backpacks { CharacterId = 1, ItemId = 3, Amount = 1 }
        );

        modelBuilder.Entity<CharactersTitles>().HasData(
            new CharactersTitles { CharacterId = 1, TitleId = 1, AcquiredAt = new DateTime(2024, 6, 10) },
            new CharactersTitles { CharacterId = 1, TitleId = 2, AcquiredAt = new DateTime(2024, 6, 9) },
            new CharactersTitles { CharacterId = 1, TitleId = 3, AcquiredAt = new DateTime(2024, 6, 8) }
        );
    }
}
    
