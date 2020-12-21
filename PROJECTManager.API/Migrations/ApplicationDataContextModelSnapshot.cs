﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJECTManager.Data;

namespace PROJECTManager.API.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    partial class ApplicationDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PROJECTManager.Data.Models.ProjectModel", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(4200)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = "p02bz8aql1",
                            CreateDate = new DateTime(2017, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A System of control collaborators.",
                            Name = "HR System"
                        },
                        new
                        {
                            Id = "a02mxlzp1a",
                            CreateDate = new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Legacy system.",
                            Name = "Storage System Project"
                        },
                        new
                        {
                            Id = "ms910alqx7",
                            CreateDate = new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            Name = "Rules Implementation in Bank Client"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
