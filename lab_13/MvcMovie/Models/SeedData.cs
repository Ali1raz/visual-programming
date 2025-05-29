using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        Genre = "Drama",
                        ReleaseDate = DateTime.Parse("1994-09-10"),
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        Genre = "Crime",
                        ReleaseDate = DateTime.Parse("1972-03-24"),
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Genre = "Action",
                        ReleaseDate = DateTime.Parse("2008-07-18"),
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        Genre = "Crime",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Forrest Gump",
                        Genre = "Drama",
                        ReleaseDate = DateTime.Parse("1994-07-06"),
                        Price = 6.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}