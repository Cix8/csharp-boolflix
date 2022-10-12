﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix.Context;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221012124148_AlterTypeOfDataInFilmAndSeriesTables")]
    partial class AlterTypeOfDataInFilmAndSeriesTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMediaInfo", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "MediaInfosId");

                    b.HasIndex("MediaInfosId");

                    b.ToTable("ActorMediaInfo");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Classification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classifications");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<int>("TVSeriesId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewsCounter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TVSeriesId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewsCounter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("csharp_boolflix.Models.MediaInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("InputDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<int?>("TVSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("VideoQuality")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilmId")
                        .IsUnique()
                        .HasFilter("[FilmId] IS NOT NULL");

                    b.HasIndex("TVSeriesId")
                        .IsUnique()
                        .HasFilter("[TVSeriesId] IS NOT NULL");

                    b.ToTable("MediaInfos");
                });

            modelBuilder.Entity("csharp_boolflix.Models.TVSeries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SeasonsCounter")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewsCounter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.ToTable("TVSeries");
                });

            modelBuilder.Entity("FeatureMediaInfo", b =>
                {
                    b.Property<int>("FeaturesId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosId")
                        .HasColumnType("int");

                    b.HasKey("FeaturesId", "MediaInfosId");

                    b.HasIndex("MediaInfosId");

                    b.ToTable("FeatureMediaInfo");
                });

            modelBuilder.Entity("GenreMediaInfo", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MediaInfosId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MediaInfosId");

                    b.HasIndex("MediaInfosId");

                    b.ToTable("GenreMediaInfo");
                });

            modelBuilder.Entity("ActorMediaInfo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.HasOne("csharp_boolflix.Models.TVSeries", "TVSeries")
                        .WithMany("Episodes")
                        .HasForeignKey("TVSeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TVSeries");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Classification", "Classification")
                        .WithMany("Films")
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classification");
                });

            modelBuilder.Entity("csharp_boolflix.Models.MediaInfo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Film", "Film")
                        .WithOne("MediaInfo")
                        .HasForeignKey("csharp_boolflix.Models.MediaInfo", "FilmId");

                    b.HasOne("csharp_boolflix.Models.TVSeries", "TVSeries")
                        .WithOne("MediaInfo")
                        .HasForeignKey("csharp_boolflix.Models.MediaInfo", "TVSeriesId");

                    b.Navigation("Film");

                    b.Navigation("TVSeries");
                });

            modelBuilder.Entity("csharp_boolflix.Models.TVSeries", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Classification", "Classification")
                        .WithMany("TVSeries")
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classification");
                });

            modelBuilder.Entity("FeatureMediaInfo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Feature", null)
                        .WithMany()
                        .HasForeignKey("FeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMediaInfo", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Models.MediaInfo", null)
                        .WithMany()
                        .HasForeignKey("MediaInfosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Models.Classification", b =>
                {
                    b.Navigation("Films");

                    b.Navigation("TVSeries");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.Navigation("MediaInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Models.TVSeries", b =>
                {
                    b.Navigation("Episodes");

                    b.Navigation("MediaInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
