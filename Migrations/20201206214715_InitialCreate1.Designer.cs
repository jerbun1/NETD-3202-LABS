﻿// <auto-generated />
using Lab5_Jermaine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab5_Jermaine.Migrations
{
    [DbContext(typeof(playerContext))]
    [Migration("20201206214715_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Lab5_Jermaine.Models.Players", b =>
                {
                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NBAteamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("int");

                    b.Property<string>("PlayerPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerTeam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerName");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Lab5_Jermaine.Models.Teams", b =>
                {
                    b.Property<string>("NBAteamName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlayerNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfPlayers")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NBAteamName");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
