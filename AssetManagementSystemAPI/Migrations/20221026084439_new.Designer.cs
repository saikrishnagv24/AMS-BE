﻿// <auto-generated />
using System;
using AssetManagementSystemAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssetManagementSystemAPI.Migrations
{
    [DbContext(typeof(AmsDBContext))]
    [Migration("20221026084439_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssetManagementSystemAPI.Model.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<string>("Name")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<string>("Password")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
