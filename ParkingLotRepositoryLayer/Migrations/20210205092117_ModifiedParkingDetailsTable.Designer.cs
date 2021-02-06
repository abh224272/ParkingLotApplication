﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingLotRepositoryLayer;

namespace ParkingLotRepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210205092117_ModifiedParkingDetailsTable")]
    partial class ModifiedParkingDetailsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingLotModelLayer.DriverTypeDetails", b =>
                {
                    b.Property<int>("DriverTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DriverCharges");

                    b.Property<string>("DriverType")
                        .IsRequired();

                    b.HasKey("DriverTypeID");

                    b.ToTable("DriverTypeDetails");
                });

            modelBuilder.Entity("ParkingLotModelLayer.ParkingDetails", b =>
                {
                    b.Property<int>("ParkingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Charges");

                    b.Property<int>("DriverType");

                    b.Property<DateTime>("EntryTime");

                    b.Property<DateTime>("ExitTime");

                    b.Property<bool>("IsEmpty");

                    b.Property<string>("ParkingSlotNumber")
                        .IsRequired();

                    b.Property<int>("ParkingType");

                    b.Property<string>("VehicleNumber")
                        .IsRequired();

                    b.Property<int>("VehicleType");

                    b.HasKey("ParkingID");

                    b.HasIndex("DriverType");

                    b.HasIndex("ParkingType");

                    b.HasIndex("VehicleType");

                    b.ToTable("ParkingDetails");
                });

            modelBuilder.Entity("ParkingLotModelLayer.ParkingTypeDetails", b =>
                {
                    b.Property<int>("ParkingTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Charges");

                    b.Property<string>("ParkingType")
                        .IsRequired();

                    b.HasKey("ParkingTypeID");

                    b.ToTable("ParkingTypeDetails");
                });

            modelBuilder.Entity("ParkingLotModelLayer.UserDetails", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailID")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Role")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("ParkingLotModelLayer.VehicleTypeDetails", b =>
                {
                    b.Property<int>("VehicleTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("VehicleCharges");

                    b.Property<string>("VehicleType")
                        .IsRequired();

                    b.HasKey("VehicleTypeID");

                    b.ToTable("VehicleTypeDetails");
                });

            modelBuilder.Entity("ParkingLotModelLayer.ParkingDetails", b =>
                {
                    b.HasOne("ParkingLotModelLayer.DriverTypeDetails", "DriverTypeDetails")
                        .WithMany()
                        .HasForeignKey("DriverType")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ParkingLotModelLayer.ParkingTypeDetails", "ParkingTypeDetails")
                        .WithMany()
                        .HasForeignKey("ParkingType")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ParkingLotModelLayer.VehicleTypeDetails", "VehicleTypeDetails")
                        .WithMany()
                        .HasForeignKey("VehicleType")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
