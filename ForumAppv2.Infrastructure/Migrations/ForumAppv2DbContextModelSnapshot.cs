﻿// <auto-generated />
using ForumAppv2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumAppv2.Infrastructure.Migrations
{
    [DbContext(typeof(ForumAppv2DbContext))]
    partial class ForumAppv2DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForumAppv2.Infrastructure.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "My first post will be about performing CRUD operations in MVC. It's so much fun.",
                            Title = "My first post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is my second post. CRUD operations in MVC are getting more and more interesting.",
                            Title = "My second post"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Hello there! I'm getting better and better with the CRUD operations in MVC. Stay tuned!",
                            Title = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
