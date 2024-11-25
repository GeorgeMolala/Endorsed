﻿// <auto-generated />
using Endorsed.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Endorsed.Migrations
{
    [DbContext(typeof(EndorsedContextDb))]
    [Migration("20241107065616_SecondAttempt")]
    partial class SecondAttempt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Endorsed.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HouseNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("ProvinceID")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurburbName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Endorsed.Models.AddressLink", b =>
                {
                    b.Property<int>("AddressLinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("AddressLinkID");

                    b.HasIndex("AddressID");

                    b.HasIndex("PersonID");

                    b.ToTable("AddressLinks");
                });

            modelBuilder.Entity("Endorsed.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Endorsed.Models.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Endorsed.Models.Qualification", b =>
                {
                    b.Property<int>("QualificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QualificationLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualififcationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QualificationID");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("Endorsed.Models.QualificationLink", b =>
                {
                    b.Property<int>("QualificationLinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("QualificationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QualificationID")
                        .HasColumnType("int");

                    b.HasKey("QualificationLinkID");

                    b.HasIndex("PersonID");

                    b.HasIndex("QualificationID");

                    b.ToTable("QualificationLinks");
                });

            modelBuilder.Entity("Endorsed.Models.Address", b =>
                {
                    b.HasOne("Endorsed.Models.Province", "Provinces")
                        .WithMany("Address")
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Endorsed.Models.AddressLink", b =>
                {
                    b.HasOne("Endorsed.Models.Address", "Address")
                        .WithMany("AddressLinks")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Endorsed.Models.Person", "Person")
                        .WithMany("AddressLinks")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Endorsed.Models.QualificationLink", b =>
                {
                    b.HasOne("Endorsed.Models.Person", "Person")
                        .WithMany("QualificationLinks")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Endorsed.Models.Qualification", "Qualification")
                        .WithMany("QualificationLinks")
                        .HasForeignKey("QualificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
