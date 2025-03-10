﻿// <auto-generated />
using System;
using JobPortal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240726060718_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("JobPortal.Models.CompanyModel", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompanyId");

                    b.ToTable("company", (string)null);
                });

            modelBuilder.Entity("JobPortal.Models.JobModel", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("JobId"));

                    b.Property<DateTime>("ApplicationDeadLine")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExperienceLevel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SalaryRange")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JobId");

                    b.ToTable("jobs", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
