using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public DbSet<Backpacks> Backpacks { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<CharacterTitles> CharacterTitles { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Titles> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Items>().HasData(new List<Items>
            {
                new Items {
                    Id = 1,
                    Name = "Jan",
                    Weight = 10
                },
                new Items {
                    Id = 2,
                    Name = "Anna",
                    Weight = 5
                }
            });

            modelBuilder.Entity<Titles>().HasData(new List<Titles>
            {
                new Titles {
                    Id = 1,
                    Name = "Title1",
                },
                new Titles {
                    Id = 2,
                    Name = "Title2",
                }
            });

            modelBuilder.Entity<CharacterTitles>().HasData(new List<CharacterTitles>
            {
                new CharacterTitles
                {
                    CharacterId = 1,
                    TitleId = 2,
                    AcquiredAt = new DateTime(2011, 6, 10),
                },
                new CharacterTitles
                {
                    CharacterId = 2,
                    TitleId = 1,
                    AcquiredAt = new DateTime(2011, 6, 11),
                },
                new CharacterTitles()
                {
                    CharacterId = 2,
                    TitleId = 2,
                    AcquiredAt = new DateTime(2011, 6, 21),
                }
            });

            modelBuilder.Entity<Characters>().HasData(new List<Characters>
            {
                new Characters
                {
                    Id = 1,
                    FirstName = "Ala",
                    LastName = "Kot",
                    CurrentWei = 50,
                    MaxWeight = 70
                },
                new Characters
                {
                    Id = 2,
                    FirstName = "Tomek",
                    LastName = "Adel",
                    CurrentWei = 80,
                    MaxWeight = 85
                },
                new Characters
                {
                    Id = 3,
                    FirstName = "Zosia",
                    LastName = "Samosia",
                    CurrentWei = 63,
                    MaxWeight = 77
                }
               
            });
            
            modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
            {
                new Backpacks
                {
                    CharacterId = 1,
                    ItemId = 1,
                    Amount = 7
                },
                new Backpacks
                {
                    CharacterId = 2,
                    ItemId = 2,
                    Amount = 13
                },
                new Backpacks
                {
                    CharacterId = 3,
                    ItemId = 2,
                    Amount = 22
                }
            });
    }
}