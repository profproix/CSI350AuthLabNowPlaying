﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NowPlaying.Data;

#nullable disable

namespace NowPlaying.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240421030102_AddingSeed")]
    partial class AddingSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NowPlaying.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "In deep space, the crew of the commercial starship Nostromo is awakened from their cryo-sleep capsules halfway through their journey home to investigate a distress call from an alien vessel.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c3/Alien_movie_poster.jpg?20200710234615",
                            Rating = "R",
                            RunTime = "1h 57m",
                            Title = "Alien"
                        },
                        new
                        {
                            Id = 2,
                            Description = "In this 1980s sci-fi classic, small-town California teen Marty McFly (Michael J. Fox) is thrown back into the '50s when an experiment by his eccentric scientist friend Doc Brown (Christopher Lloyd) goes awry.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Rating = "PG",
                            RunTime = "1h 56m",
                            Title = "Back to the Future"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Adm. James T. Kirk (William Shatner) has defeated his archenemy but at great cost. His friend Spock has apparently been killed, the USS Enterprise is being scrapped, and starship physician Dr. Leonard \"Bones\" McCoy (DeForest Kelley) has taken ill. McCoy's odd behavior is evidence he's harboring Spock's katra, or animating spirit, and Kirk seeks to take the Enterprise back to the Genesis Planet and find his friend. Rebuffed, Kirk takes dramatic action that results in war with deadly Klingons.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/b/b6/Star_Trek_III_The_Search_for_Spock.png",
                            Rating = "PG",
                            RunTime = "1h 45m",
                            Title = "Star Trek III: The Search for Spock"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}