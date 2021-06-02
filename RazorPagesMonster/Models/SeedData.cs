using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonster.Data;

namespace RazorPagesMonster.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonsterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonsterContext>>()))
            {
                // Look for any Monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "Dracula",
                        ReleaseDate = DateTime.Parse("1897-1-1"),
                        Genre = "Were Monster",
                        Price = 1.15M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Pikachu",
                        ReleaseDate = DateTime.Parse("1996-2-27"),
                        Genre = "Pokemon",
                        Price = 5.67M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Slimer",
                        ReleaseDate = DateTime.Parse("1984-6-15"),
                        Genre = "Ghostbusters",
                        Price = 34.55M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Alien",
                        ReleaseDate = DateTime.Parse("1979-5-25"),
                        Genre = "Space Monsters",
                        Price = 10.00M,
                        Rating = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
