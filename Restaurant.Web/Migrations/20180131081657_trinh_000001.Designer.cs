﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Restaurant.Common;
using Restaurant.Entities;
using System;

namespace Restaurant.Web.Migrations
{
    [DbContext(typeof(InstanceEntities))]
    [Migration("20180131081657_trinh_000001")]
    partial class trinh_000001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimName")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("Restaurant.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("S3FileKey")
                        .HasMaxLength(250);

                    b.Property<string>("Url")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Restaurant.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<int>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Restaurant.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClaimId");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Restaurant.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Password")
                        .HasMaxLength(250);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(250);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(250);

                    b.Property<int?>("UserStatusId");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Restaurant.Entities.UserLoginToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiredDated");

                    b.Property<bool?>("IsRememberMe");

                    b.Property<DateTime>("LastLoginDated");

                    b.Property<string>("Token")
                        .HasMaxLength(250);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLoginToken");
                });

            modelBuilder.Entity("Restaurant.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<int?>("AvatarId");

                    b.Property<string>("City")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("FirstName")
                        .HasMaxLength(250);

                    b.Property<string>("LastName")
                        .HasMaxLength(250);

                    b.Property<int?>("UserId");

                    b.Property<bool?>("WasVerifiedEmail");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Restaurant.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RoleId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Restaurant.Entities.RoleClaim", b =>
                {
                    b.HasOne("Restaurant.Entities.Claim", "Claim")
                        .WithMany("RoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Restaurant.Entities.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restaurant.Entities.UserLoginToken", b =>
                {
                    b.HasOne("Restaurant.Entities.User", "User")
                        .WithMany("UserLoginTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restaurant.Entities.UserProfile", b =>
                {
                    b.HasOne("Restaurant.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("Restaurant.Entities.User", "User")
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Restaurant.Entities.UserRole", b =>
                {
                    b.HasOne("Restaurant.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Restaurant.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
