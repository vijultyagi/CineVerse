﻿// <auto-generated />
using System;
using CineVerseWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CineVerseWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230707062013_AddMovietoDb")]
    partial class AddMovietoDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CineVerseWeb.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Actors")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
