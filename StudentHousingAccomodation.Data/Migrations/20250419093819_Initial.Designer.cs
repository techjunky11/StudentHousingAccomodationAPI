﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentHousingAccomodation.Data.Data;

#nullable disable

namespace StudentHousingAccomodation.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250419093819_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.LandLordInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LandLordInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyAmentiesInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmentiesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PropertyInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyInformationId");

                    b.ToTable("PropertyAmentiesInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFormat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageResolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ImageUploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PropertyInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomInformationGuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoomInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyInformationId");

                    b.HasIndex("RoomInformationId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsAvailable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LandLordInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("PropertLongitudeCoordinates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PropertyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PropertyIsApprovedByAdmin")
                        .HasColumnType("bit");

                    b.Property<decimal?>("PropertyLatitudeCoordinates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PropertyMonthlyRent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TitleDeedsOrBillUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandLordInformationId");

                    b.HasIndex("StudentInformationId");

                    b.ToTable("PropertyInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyRating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PropertyInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyInformationId");

                    b.HasIndex("StudentInformationId");

                    b.ToTable("PropertyRatings");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.RefreshTokens", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.RoomInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsAvailable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PropertyInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProperyInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoomDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RoomMonthlyRent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyInformationId");

                    b.HasIndex("StudentInformationId");

                    b.ToTable("RoomInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.StudentInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StudentInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.StudentInterests", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Interest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentInformationId");

                    b.ToTable("StudentInterests");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastPasswordChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginAttempts")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.UserRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyAmentiesInformation", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.PropertyInformation", null)
                        .WithMany("Amenties")
                        .HasForeignKey("PropertyInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyImage", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.PropertyInformation", null)
                        .WithMany("PropertyImages")
                        .HasForeignKey("PropertyInformationId");

                    b.HasOne("StudentHousingAccomodation.Domain.Entities.RoomInformation", null)
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomInformationId");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyInformation", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.LandLordInformation", "LandLordInformation")
                        .WithMany("Properties")
                        .HasForeignKey("LandLordInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentHousingAccomodation.Domain.Entities.StudentInformation", null)
                        .WithMany("PropertyInformation")
                        .HasForeignKey("StudentInformationId");

                    b.Navigation("LandLordInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyRating", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.PropertyInformation", null)
                        .WithMany("PropertyRatings")
                        .HasForeignKey("PropertyInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentHousingAccomodation.Domain.Entities.StudentInformation", "StudentInformation")
                        .WithMany("PropertyRatings")
                        .HasForeignKey("StudentInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentInformation");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.RoomInformation", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.PropertyInformation", null)
                        .WithMany("PropertyRooms")
                        .HasForeignKey("PropertyInformationId");

                    b.HasOne("StudentHousingAccomodation.Domain.Entities.StudentInformation", null)
                        .WithMany("RoomInformation")
                        .HasForeignKey("StudentInformationId");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.StudentInformation", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.StudentInterests", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.StudentInformation", null)
                        .WithMany("StudentInterests")
                        .HasForeignKey("StudentInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.UserRoles", b =>
                {
                    b.HasOne("StudentHousingAccomodation.Domain.Entities.User", null)
                        .WithOne("UserRole")
                        .HasForeignKey("StudentHousingAccomodation.Domain.Entities.UserRoles", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.LandLordInformation", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.PropertyInformation", b =>
                {
                    b.Navigation("Amenties");

                    b.Navigation("PropertyImages");

                    b.Navigation("PropertyRatings");

                    b.Navigation("PropertyRooms");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.RoomInformation", b =>
                {
                    b.Navigation("RoomImages");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.StudentInformation", b =>
                {
                    b.Navigation("PropertyInformation");

                    b.Navigation("PropertyRatings");

                    b.Navigation("RoomInformation");

                    b.Navigation("StudentInterests");
                });

            modelBuilder.Entity("StudentHousingAccomodation.Domain.Entities.User", b =>
                {
                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
