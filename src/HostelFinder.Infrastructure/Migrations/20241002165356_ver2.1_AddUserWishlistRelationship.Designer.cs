﻿// <auto-generated />
using System;
using HostelFinder.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HostelFinder.Infrastructure.Migrations
{
    [DbContext(typeof(HostelFinderDbContext))]
    [Migration("20241002165356_ver2.1_AddUserWishlistRelationship")]
    partial class ver21_AddUserWishlistRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HostelFinder.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("HostelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DetailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HostelId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.BlackListToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlackListTokens");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.BookingRequest", b =>
                {
                    b.Property<Guid>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("DateRequest")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RequestId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("BookingRequests");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Hostel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Coordinates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("HostelName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LandlordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<float?>("Size")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Hostels");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("HostelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("HostelId");

                    b.HasIndex("RoomId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HostelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostelId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("DateAvailable")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("HostelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("MonthlyRentCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrimaryImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<decimal?>("Size")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HostelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.RoomAmenities", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasAirConditioner")
                        .HasColumnType("bit");

                    b.Property<bool>("HasElevator")
                        .HasColumnType("bit");

                    b.Property<bool>("HasEmergencyExit")
                        .HasColumnType("bit");

                    b.Property<bool>("HasFireExtinguisher")
                        .HasColumnType("bit");

                    b.Property<bool>("HasFridge")
                        .HasColumnType("bit");

                    b.Property<bool>("HasGarage")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWifi")
                        .HasColumnType("bit");

                    b.Property<string>("OtherAmenities")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RoomId");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.RoomDetails", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BathRooms")
                        .HasColumnType("int");

                    b.Property<int>("BedRooms")
                        .HasColumnType("int");

                    b.Property<int>("Kitchen")
                        .HasColumnType("int");

                    b.Property<string>("OtherDetails")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("RoomId");

                    b.ToTable("RoomDetails");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HostelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HostelId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.ServiceCost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("ServiceCosts");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasMaxLength(255)
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Wishlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.WishlistRoom", b =>
                {
                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WishlistId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoomId", "WishlistId");

                    b.HasIndex("WishlistId");

                    b.ToTable("WishlistRooms");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Address", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Hostel", "Hostel")
                        .WithOne("Address")
                        .HasForeignKey("HostelFinder.Domain.Entities.Address", "HostelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hostel");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.BookingRequest", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithMany("BookingRequests")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HostelFinder.Domain.Entities.User", "User")
                        .WithMany("BookingRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Hostel", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.User", "Landlord")
                        .WithMany("Hostels")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Image", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Hostel", "Hostel")
                        .WithMany("Images")
                        .HasForeignKey("HostelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithMany("Images")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hostel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Review", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Hostel", "Hostel")
                        .WithMany("Reviews")
                        .HasForeignKey("HostelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HostelFinder.Domain.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hostel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Room", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Hostel", "Hostel")
                        .WithMany("Rooms")
                        .HasForeignKey("HostelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hostel");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.RoomAmenities", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithOne("RoomAmenities")
                        .HasForeignKey("HostelFinder.Domain.Entities.RoomAmenities", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.RoomDetails", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithOne("RoomDetails")
                        .HasForeignKey("HostelFinder.Domain.Entities.RoomDetails", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Service", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Hostel", "Hostel")
                        .WithMany("Services")
                        .HasForeignKey("HostelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hostel");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.ServiceCost", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithMany("ServiceCosts")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Wishlist", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.User", "User")
                        .WithOne("Wishlists")
                        .HasForeignKey("HostelFinder.Domain.Entities.Wishlist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.WishlistRoom", b =>
                {
                    b.HasOne("HostelFinder.Domain.Entities.Room", "Room")
                        .WithMany("WishlistRooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HostelFinder.Domain.Entities.Wishlist", "Wishlist")
                        .WithMany("WishlistRooms")
                        .HasForeignKey("WishlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Wishlist");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Hostel", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Images");

                    b.Navigation("Reviews");

                    b.Navigation("Rooms");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Room", b =>
                {
                    b.Navigation("BookingRequests");

                    b.Navigation("Images");

                    b.Navigation("RoomAmenities")
                        .IsRequired();

                    b.Navigation("RoomDetails")
                        .IsRequired();

                    b.Navigation("ServiceCosts");

                    b.Navigation("WishlistRooms");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.User", b =>
                {
                    b.Navigation("BookingRequests");

                    b.Navigation("Hostels");

                    b.Navigation("Reviews");

                    b.Navigation("Wishlists");
                });

            modelBuilder.Entity("HostelFinder.Domain.Entities.Wishlist", b =>
                {
                    b.Navigation("WishlistRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
