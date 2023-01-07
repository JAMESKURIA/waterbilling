﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WaterBilling.Data;

#nullable disable

namespace WaterBilling.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230107160205_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WaterBilling.Api.CustomerSupport.Entities.MeterReader", b =>
                {
                    b.Property<int>("MeterReaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MeterReaderId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ZoneId")
                        .HasColumnType("integer");

                    b.HasKey("MeterReaderId");

                    b.HasIndex("ZoneId")
                        .IsUnique();

                    b.ToTable("MeterReader");
                });

            modelBuilder.Entity("WaterBilling.Api.Customers.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("MeterId")
                        .HasColumnType("integer");

                    b.Property<string>("Msisdn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.HasIndex("MeterId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WaterBilling.Api.Infrastructure.Entities.Zone", b =>
                {
                    b.Property<int>("ZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ZoneId"));

                    b.Property<string>("AreaCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ZoneId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("WaterBilling.Api.WaterUsage.Entities.Meter", b =>
                {
                    b.Property<int>("MeterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MeterId"));

                    b.Property<string>("CurrReading")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DiscDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DiscReason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ZoneId")
                        .HasColumnType("integer");

                    b.HasKey("MeterId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("WaterBilling.Api.CustomerSupport.Entities.MeterReader", b =>
                {
                    b.HasOne("WaterBilling.Api.Infrastructure.Entities.Zone", "Zone")
                        .WithOne("MeterReader")
                        .HasForeignKey("WaterBilling.Api.CustomerSupport.Entities.MeterReader", "ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("WaterBilling.Api.Customers.Entities.Customer", b =>
                {
                    b.HasOne("WaterBilling.Api.WaterUsage.Entities.Meter", "Meter")
                        .WithOne("Customer")
                        .HasForeignKey("WaterBilling.Api.Customers.Entities.Customer", "MeterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meter");
                });

            modelBuilder.Entity("WaterBilling.Api.WaterUsage.Entities.Meter", b =>
                {
                    b.HasOne("WaterBilling.Api.Infrastructure.Entities.Zone", "Zone")
                        .WithMany("Meters")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("WaterBilling.Api.Infrastructure.Entities.Zone", b =>
                {
                    b.Navigation("MeterReader")
                        .IsRequired();

                    b.Navigation("Meters");
                });

            modelBuilder.Entity("WaterBilling.Api.WaterUsage.Entities.Meter", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
