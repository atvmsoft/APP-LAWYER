﻿// <auto-generated />
using System;
using Application.IO.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.IO.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181210164622_RDS-20181210-02")]
    partial class RDS2018121002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Application.IO.Core.Domain.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("IdApplicationUser");

                    b.HasKey("Id");

                    b.HasIndex("IdApplicationUser");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.Lawyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdApplicationUser");

                    b.Property<string>("OAB")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("IdApplicationUser");

                    b.ToTable("Lawyers");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.LawyerOccupationArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MinScore")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("LawyerOccupationAreas");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.LawyerSociety", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("BusinessFax")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("BusinessPhone")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Complement")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdLawyer");

                    b.Property<int>("IdPostalCodeAdress");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("IdLawyer");

                    b.HasIndex("IdPostalCodeAdress");

                    b.ToTable("LawyersSociety");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.OccupationAreaLawyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdLawyer");

                    b.Property<int>("IdLawyerOccupationArea");

                    b.Property<double>("LawyerScore")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdLawyer");

                    b.HasIndex("IdLawyerOccupationArea");

                    b.ToTable("OccupationAreasLawyer");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.System.AdministratorSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("IdApplicationUser");

                    b.HasKey("Id");

                    b.HasIndex("IdApplicationUser");

                    b.ToTable("AdministratorsSystem");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.System.PostalCodeAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<bool>("InsertByUser");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .HasName("IDX_Code")
                        .HasAnnotation("SqlServer:IncludeIndex", "[Id], [Place], [Neighborhood], [City], [State], [StateName], [Country], [InsertByUser]");

                    b.ToTable("PostalCodeAdress");
                });

            modelBuilder.Entity("Application.IO.Core.Identity.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UserCreated");

                    b.Property<DateTime?>("UserEmailConfirm");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Customers.Customer", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Customers")
                        .HasForeignKey("IdApplicationUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.Lawyer", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Lawyers")
                        .HasForeignKey("IdApplicationUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.LawyerSociety", b =>
                {
                    b.HasOne("Application.IO.Core.Domain.Lawyers.Lawyer", "Lawyer")
                        .WithMany("LawyersSociety")
                        .HasForeignKey("IdLawyer")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.IO.Core.Domain.System.PostalCodeAdress", "PostalCodeAdress")
                        .WithMany("LawyersSociety")
                        .HasForeignKey("IdPostalCodeAdress")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.IO.Core.Domain.Lawyers.OccupationAreaLawyer", b =>
                {
                    b.HasOne("Application.IO.Core.Domain.Lawyers.Lawyer", "Lawyer")
                        .WithMany("OccupationAreasLawyer")
                        .HasForeignKey("IdLawyer")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.IO.Core.Domain.Lawyers.LawyerOccupationArea", "LawyerOccupationAreas")
                        .WithMany("OccupationAreasLawyer")
                        .HasForeignKey("IdLawyerOccupationArea")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.IO.Core.Domain.System.AdministratorSystem", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("AdmUsersSystem")
                        .HasForeignKey("IdApplicationUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Application.IO.Core.Identity.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
