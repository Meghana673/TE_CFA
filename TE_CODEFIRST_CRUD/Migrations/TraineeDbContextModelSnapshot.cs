﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TE_CODEFIRST_CRUD.Data;

#nullable disable

namespace TE_CODEFIRST_CRUD.Migrations
{
    [DbContext(typeof(TraineeDbContext))]
    partial class TraineeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TE_CODEFIRST_CRUD.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeID"), 1L, 1);

                    b.Property<string>("TConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraineeAge")
                        .HasColumnType("int");

                    b.Property<string>("TraineeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineeMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraineeID");

                    b.ToTable("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
