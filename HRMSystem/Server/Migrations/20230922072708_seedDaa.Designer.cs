﻿// <auto-generated />
using System;
using HRMSystem.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMSystem.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922072708_seedDaa")]
    partial class seedDaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRMSystem.Shared.Models.Department", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HRMSystem.Shared.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Created = new DateTime(2023, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified),
                            DepartmentId = 1234,
                            FirstName = "FirstName1",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "LastName1"
                        },
                        new
                        {
                            ID = 2,
                            Created = new DateTime(2022, 8, 27, 8, 30, 39, 999, DateTimeKind.Unspecified),
                            DepartmentId = 1235,
                            FirstName = "FirstName2",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "LastName2"
                        });
                });

            modelBuilder.Entity("HRMSystem.Shared.Models.Employee", b =>
                {
                    b.HasOne("HRMSystem.Shared.Models.Department", "Department")
                        .WithMany("Leads")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HRMSystem.Shared.Models.Department", b =>
                {
                    b.Navigation("Leads");
                });
#pragma warning restore 612, 618
        }
    }
}
