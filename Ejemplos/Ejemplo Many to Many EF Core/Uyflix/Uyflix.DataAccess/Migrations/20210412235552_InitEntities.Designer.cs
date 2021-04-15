﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uyflix.DataAccess;

namespace Uyflix.DataAccess.Migrations
{
    [DbContext(typeof(UyflixContext))]
    [Migration("20210412235552_InitEntities")]
    partial class InitEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.Property<int>("StarringId")
                        .HasColumnType("int");

                    b.HasKey("MoviesId", "StarringId");

                    b.HasIndex("StarringId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.MovieCategory", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MoviesCategories");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("Uyflix.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uyflix.Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("StarringId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.MovieCategory", b =>
                {
                    b.HasOne("Uyflix.Domain.Entities.Category", "Category")
                        .WithMany("MoviesCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uyflix.Domain.Entities.Movie", "Movie")
                        .WithMany("MoviesCategories")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.Category", b =>
                {
                    b.Navigation("MoviesCategories");
                });

            modelBuilder.Entity("Uyflix.Domain.Entities.Movie", b =>
                {
                    b.Navigation("MoviesCategories");
                });
#pragma warning restore 612, 618
        }
    }
}