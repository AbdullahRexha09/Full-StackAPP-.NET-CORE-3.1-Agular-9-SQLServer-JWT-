﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapplication.Models;

namespace webapplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201226162418_emailIsUnique")]
    partial class emailIsUnique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapplication.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Latitude")
                        .HasColumnName("latitude")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Longitude")
                        .HasColumnName("longitude")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b44062bd-9f2d-49dc-8dae-fc1059cf6837"),
                            Latitude = "13.4050",
                            Longitude = "52.5200",
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("ce9736ec-9a31-4796-bda4-2113874815c1"),
                            Latitude = "4.9041",
                            Longitude = "52.3676",
                            Name = "Amsterdam"
                        },
                        new
                        {
                            Id = new Guid("6f34f714-098f-4a65-bcf9-800919cab23e"),
                            Latitude = "14.5058",
                            Longitude = "46.0569",
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = new Guid("54e486dc-80e8-498d-a407-6edae2475b5d"),
                            Latitude = "20.4489",
                            Longitude = "44.7866",
                            Name = "Belgrade"
                        },
                        new
                        {
                            Id = new Guid("af50ce58-559a-4be5-bb84-225fd67b2a96"),
                            Latitude = "15.9819",
                            Longitude = "45.8150",
                            Name = "Zagreb"
                        },
                        new
                        {
                            Id = new Guid("56e827e9-a3c7-49ac-88fb-122addf14b1d"),
                            Latitude = "18.4131",
                            Longitude = "43.8563",
                            Name = "Sarajevo"
                        },
                        new
                        {
                            Id = new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"),
                            Latitude = "21.1655",
                            Longitude = "42.6629",
                            Name = "Prishtina"
                        },
                        new
                        {
                            Id = new Guid("6a3ee7fc-0460-4fb9-a21d-416cd9ea1590"),
                            Latitude = "12.4964",
                            Longitude = "41.9028",
                            Name = "Rome"
                        },
                        new
                        {
                            Id = new Guid("adcfec71-0fb1-4397-8ca6-376b7b262c9a"),
                            Latitude = "2.3522",
                            Longitude = "48.8566",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("e6be14e6-f54c-492f-9899-be29015b6642"),
                            Latitude = "3.7038",
                            Longitude = "40.4168",
                            Name = "Madrid"
                        },
                        new
                        {
                            Id = new Guid("5f3ab6cd-0d03-4380-86f0-b8d87b7da596"),
                            Latitude = "28.9784",
                            Longitude = "41.0082",
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = new Guid("293c144a-d080-4aec-9e5c-cdd9d19021fd"),
                            Latitude = "37.6173",
                            Longitude = "55.7558",
                            Name = "Moscow"
                        },
                        new
                        {
                            Id = new Guid("c9d721a5-77b5-468b-b076-d5170c322910"),
                            Latitude = "18.0686",
                            Longitude = "59.3293",
                            Name = "Stockholm"
                        });
                });

            modelBuilder.Entity("webapplication.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<Guid>("CityId")
                        .HasColumnName("cityid")
                        .HasColumnType("uniqueidentifier")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec6e38a2-97a8-44db-be27-640906e0ca32"),
                            Address = "Kosove",
                            CityId = new Guid("58ca7a2d-ef9d-47da-9ba2-2a27b76da85c"),
                            Name = "Filan Fisteku"
                        });
                });

            modelBuilder.Entity("webapplication.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnName("refreshtokenexpirytime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnName("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("webapplication.Models.Location", b =>
                {
                    b.HasOne("webapplication.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
