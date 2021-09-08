﻿// <auto-generated />
using System;
using CodeFirstSetup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstSetup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CVEducation", b =>
                {
                    b.Property<int>("EducationsId")
                        .HasColumnType("int");

                    b.Property<int>("cvsId")
                        .HasColumnType("int");

                    b.HasKey("EducationsId", "cvsId");

                    b.HasIndex("cvsId");

                    b.ToTable("CVEducation");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.CV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DriverLicence")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HaveCar")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkLocaltion")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.ToTable("cv");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasRadio")
                        .HasColumnType("bit");

                    b.Property<int?>("Manufacturerid")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Manufacturerid");

                    b.ToTable("car");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Contries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contries");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("educations");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Kurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime>("LastModeified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectureDay")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Startday")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("kurs");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Manufacturer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("manufacturers");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoadVolumeKvm")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int?>("Manufactureid")
                        .HasColumnType("int");

                    b.Property<string>("RegNumber")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("Manufactureid");

                    b.ToTable("truck");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.UserRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Usertype")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContryId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CVEducation", b =>
                {
                    b.HasOne("CodeFirstSetup.Data.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstSetup.Data.CV", null)
                        .WithMany()
                        .HasForeignKey("cvsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Car", b =>
                {
                    b.HasOne("CodeFirstSetup.Data.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturerid");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.Truck", b =>
                {
                    b.HasOne("CodeFirstSetup.Data.Manufacturer", "Manufacture")
                        .WithMany()
                        .HasForeignKey("Manufactureid");

                    b.Navigation("Manufacture");
                });

            modelBuilder.Entity("CodeFirstSetup.Data.UserRegistration", b =>
                {
                    b.HasOne("CodeFirstSetup.Data.Contries", "Contry")
                        .WithMany()
                        .HasForeignKey("ContryId");

                    b.Navigation("Contry");
                });
#pragma warning restore 612, 618
        }
    }
}
