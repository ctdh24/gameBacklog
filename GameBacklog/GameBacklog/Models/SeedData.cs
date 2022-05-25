using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GameBacklog.Data;
using GameBacklog.Models;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameBacklogContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GameBacklogContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Final Fantasy XIV: A Realm Reborn",
                        ReleaseDate = DateTime.Parse("2013-8-24"),
                        Genre = "MMORPG",
                        Price = 59.99M
                    },

                    new Game
                    {
                        Title = "Phantasy Star Online 2: New Genisis",
                        ReleaseDate = DateTime.Parse("2012-7-4"),
                        Genre = "MMORPG",
                        Price = 0.0M
                    },

                    new Game
                    {
                        Title = "Elden Ring",
                        ReleaseDate = DateTime.Parse("2022-2-25"),
                        Genre = "Open World",
                        Price = 59.99M
                    },

                    new Game
                    {
                        Title = "Genshin Impact",
                        ReleaseDate = DateTime.Parse("2020-9-28"),
                        Genre = "Open World",
                        Price = 0.0M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}