﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameApi.Data;

#nullable disable

namespace VideoGameApi.Migrations
{
    [DbContext(typeof(VideoGameDBcontext))]
    partial class VideoGameDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("VideoGameApi.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Developer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platform")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Insomniac Games",
                            Platform = "PS5",
                            Publisher = "Sony Interactive Entertainment",
                            Title = "Spider-Man 2"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Gameloft",
                            Platform = "Android",
                            Publisher = "Gameloft",
                            Title = "Gangster 4"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "Nintendo",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "The Legend of Zelda: Tears of the Kingdom"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "Square Enix",
                            Platform = "PS5",
                            Publisher = "Square Enix",
                            Title = "Final Fantasy XVI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
