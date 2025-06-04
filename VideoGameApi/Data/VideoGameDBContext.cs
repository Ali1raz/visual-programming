using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace VideoGameApi.Data
{
    public class VideoGameDBcontext(DbContextOptions<VideoGameDBcontext> options): DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                    new VideoGame
                    {
                        Id = 1,
                        Title = "Spider-Man 2",
                        Developer = "Insomniac Games",
                        Platform = "PS5",
                        Publisher = "Sony Interactive Entertainment"
                    },
                    new VideoGame
                    {
                        Id = 2,
                        Title = "Gangster 4",
                        Developer = "Gameloft",
                        Platform = "Android",
                        Publisher = "Gameloft"
                    },
                    new VideoGame
                    {
                        Id = 3,
                        Title = "The Legend of Zelda: Tears of the Kingdom",
                        Developer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Publisher = "Nintendo"
                    },
                    new VideoGame
                    {
                        Id = 4,
                        Title = "Final Fantasy XVI",
                        Developer = "Square Enix",
                        Platform = "PS5",
                        Publisher = "Square Enix"
                    }
                );
        }
    }


}
