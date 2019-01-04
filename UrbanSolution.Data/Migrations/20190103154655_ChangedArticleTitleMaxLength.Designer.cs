﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrbanSolution.Data;

namespace UrbanSolution.Data.Migrations
{
    [DbContext(typeof(UrbanSolutionDbContext))]
    [Migration("20190103154655_ChangedArticleTitleMaxLength")]
    partial class ChangedArticleTitleMaxLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UrbanSolution.Models.AdminLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Activity");

                    b.Property<string>("AdminId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("EditedUserId");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("EditedUserId");

                    b.ToTable("AdminLogs");
                });

            modelBuilder.Entity("UrbanSolution.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId");

                    b.Property<int>("CloudinaryImageId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CloudinaryImageId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("UrbanSolution.Models.CloudinaryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Length");

                    b.Property<string>("PicturePublicId");

                    b.Property<string>("PictureThumbnailUrl");

                    b.Property<string>("PictureUrl");

                    b.Property<DateTime>("UploadedOn");

                    b.Property<string>("UploaderId");

                    b.HasKey("Id");

                    b.HasIndex("UploaderId");

                    b.ToTable("CloudinaryImages");
                });

            modelBuilder.Entity("UrbanSolution.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("EventId");

                    b.Property<DateTime>("PostedOn");

                    b.Property<string>("PublisherId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("UrbanSolution.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CreatorId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("EndDate");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("PictureUrl");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("UrbanSolution.Models.ManagerLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Activity");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("ManagerId");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerLogs");
                });

            modelBuilder.Entity("UrbanSolution.Models.MappingTables.EventUser", b =>
                {
                    b.Property<string>("ParticipantId");

                    b.Property<int>("EventId");

                    b.HasKey("ParticipantId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EventUsers");
                });

            modelBuilder.Entity("UrbanSolution.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ResolvedIssueId");

                    b.Property<string>("UserId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ResolvedIssueId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("UrbanSolution.Models.ResolvedIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CloudinaryImageId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("PublisherId")
                        .IsRequired();

                    b.Property<double>("Rating");

                    b.Property<DateTime>("ResolvedOn");

                    b.Property<int?>("UrbanIssueId");

                    b.HasKey("Id");

                    b.HasIndex("CloudinaryImageId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("UrbanIssueId")
                        .IsUnique()
                        .HasFilter("[UrbanIssueId] IS NOT NULL");

                    b.ToTable("ResolvedIssues");
                });

            modelBuilder.Entity("UrbanSolution.Models.UrbanIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressStreet")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("CloudinaryImageId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<bool>("IsApproved");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<string>("PublisherId")
                        .IsRequired();

                    b.Property<int>("Region");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CloudinaryImageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("UrbanIssues");
                });

            modelBuilder.Entity("UrbanSolution.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("ManagedRegion");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UrbanSolution.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UrbanSolution.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UrbanSolution.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanSolution.Models.AdminLog", b =>
                {
                    b.HasOne("UrbanSolution.Models.User", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("UrbanSolution.Models.User", "EditedUser")
                        .WithMany()
                        .HasForeignKey("EditedUserId");
                });

            modelBuilder.Entity("UrbanSolution.Models.Article", b =>
                {
                    b.HasOne("UrbanSolution.Models.User", "Author")
                        .WithMany("PublishedArticles")
                        .HasForeignKey("AuthorId");

                    b.HasOne("UrbanSolution.Models.CloudinaryImage", "CloudinaryImage")
                        .WithMany()
                        .HasForeignKey("CloudinaryImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanSolution.Models.CloudinaryImage", b =>
                {
                    b.HasOne("UrbanSolution.Models.User", "Uploader")
                        .WithMany("UploadedImages")
                        .HasForeignKey("UploaderId");
                });

            modelBuilder.Entity("UrbanSolution.Models.Comment", b =>
                {
                    b.HasOne("UrbanSolution.Models.Event")
                        .WithMany("Comments")
                        .HasForeignKey("EventId");

                    b.HasOne("UrbanSolution.Models.User", "Publisher")
                        .WithMany("Comments")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanSolution.Models.Event", b =>
                {
                    b.HasOne("UrbanSolution.Models.User", "Creator")
                        .WithMany("EventsCreated")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("UrbanSolution.Models.ManagerLog", b =>
                {
                    b.HasOne("UrbanSolution.Models.User", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("UrbanSolution.Models.MappingTables.EventUser", b =>
                {
                    b.HasOne("UrbanSolution.Models.Event", "Event")
                        .WithMany("Participants")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.User", "Participant")
                        .WithMany("EventsParticipations")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanSolution.Models.Rating", b =>
                {
                    b.HasOne("UrbanSolution.Models.ResolvedIssue", "ResolvedIssue")
                        .WithMany("Ratings")
                        .HasForeignKey("ResolvedIssueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("UrbanSolution.Models.ResolvedIssue", b =>
                {
                    b.HasOne("UrbanSolution.Models.CloudinaryImage", "CloudinaryImage")
                        .WithMany()
                        .HasForeignKey("CloudinaryImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.User", "Publisher")
                        .WithMany("ResolvedIssues")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.UrbanIssue", "UrbanIssue")
                        .WithOne("ResolvedIssue")
                        .HasForeignKey("UrbanSolution.Models.ResolvedIssue", "UrbanIssueId");
                });

            modelBuilder.Entity("UrbanSolution.Models.UrbanIssue", b =>
                {
                    b.HasOne("UrbanSolution.Models.CloudinaryImage", "CloudinaryImage")
                        .WithMany()
                        .HasForeignKey("CloudinaryImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanSolution.Models.User", "Publisher")
                        .WithMany("UrbanIssues")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
