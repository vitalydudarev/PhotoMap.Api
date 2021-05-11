﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PhotoMap.Api.Database;

namespace PhotoMap.Api.Migrations
{
    [DbContext(typeof(PhotoMapContext))]
    [Migration("20201029193923_AddedDropboxColumns")]
    partial class AddedDropboxColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PhotoMap.Api.Database.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("AddedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateTimeTaken")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExifString")
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<bool>("HasGps")
                        .HasColumnType("boolean");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<long?>("PhotoFileId")
                        .HasColumnType("bigint");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<long>("ThumbnailLargeFileId")
                        .HasColumnType("bigint");

                    b.Property<long>("ThumbnailSmallFileId")
                        .HasColumnType("bigint");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("PhotoMap.Api.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DropboxStatus")
                        .HasColumnType("integer");

                    b.Property<string>("DropboxToken")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("DropboxTokenExpiresOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("YandexDiskStatus")
                        .HasColumnType("integer");

                    b.Property<string>("YandexDiskToken")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("YandexDiskTokenExpiresOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PhotoMap.Api.Database.Entities.Photo", b =>
                {
                    b.HasOne("PhotoMap.Api.Database.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
