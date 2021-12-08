﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PosTrack.Data;

namespace PosTrack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211208112042_InitialTagTrolley")]
    partial class InitialTagTrolley
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PosTrack.Data.Models.Lot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LotDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeCreatedId")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("WaterContent")
                        .HasColumnType("decimal(8,3)");

                    b.HasKey("Id");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("PosTrack.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rfid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TagLabel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PosTrack.Data.Models.Trolley", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("InService")
                        .HasColumnType("bit");

                    b.Property<int>("Label")
                        .HasColumnType("int");

                    b.Property<int>("LeftTagID")
                        .HasColumnType("int");

                    b.Property<int>("RightTagID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeftTagID")
                        .IsUnique();

                    b.HasIndex("RightTagID")
                        .IsUnique();

                    b.ToTable("Trolleys");
                });

            modelBuilder.Entity("PosTrack.Data.Models.Trolley", b =>
                {
                    b.HasOne("PosTrack.Data.Models.Tag", "LeftTag")
                        .WithOne()
                        .HasForeignKey("PosTrack.Data.Models.Trolley", "LeftTagID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PosTrack.Data.Models.Tag", "RightTag")
                        .WithOne()
                        .HasForeignKey("PosTrack.Data.Models.Trolley", "RightTagID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LeftTag");

                    b.Navigation("RightTag");
                });
#pragma warning restore 612, 618
        }
    }
}