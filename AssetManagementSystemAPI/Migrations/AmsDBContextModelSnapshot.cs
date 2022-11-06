﻿// <auto-generated />
using System;
using AssetManagementSystemAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssetManagementSystemAPI.Migrations
{
    [DbContext(typeof(AmsDBContext))]
    partial class AmsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssetManagementSystemAPI.Model.AddAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssetCost")
                        .HasColumnType("int");

                    b.Property<string>("AssetId")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<DateTime?>("AssetPurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("CpuId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HddId")
                        .HasColumnType("int");

                    b.Property<int?>("RamId")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasMaxLength(440)
                        .HasColumnType("nvarchar(440)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("CpuId");

                    b.HasIndex("HddId");

                    b.HasIndex("RamId");

                    b.ToTable("AddAsset");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetTypeName")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AssetType");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.CpuType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpuTypeName")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CpuType");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteStatus")
                        .HasColumnType("bit");

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<string>("Description")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.HasKey("id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.RamType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RamTypeName")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RamType");
                });

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

            modelBuilder.Entity("AssetManagementSystemAPI.Model.AddAsset", b =>
                {
                    b.HasOne("AssetManagementSystemAPI.Model.AssetType", "AssetTypes")
                        .WithMany("AddAssets")
                        .HasForeignKey("AssetTypeId");

                    b.HasOne("AssetManagementSystemAPI.Model.CpuType", "CpuTypes")
                        .WithMany("AddAssets")
                        .HasForeignKey("CpuId");

                    b.HasOne("AssetManagementSystemAPI.Model.HarddiscType", "HarddiscTypes")
                        .WithMany("AddAssets")
                        .HasForeignKey("HddId");

                    b.HasOne("AssetManagementSystemAPI.Model.RamType", "RamTypes")
                        .WithMany("AddAssets")
                        .HasForeignKey("RamId");

                    b.Navigation("AssetTypes");

                    b.Navigation("CpuTypes");

                    b.Navigation("HarddiscTypes");

                    b.Navigation("RamTypes");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.AssetType", b =>
                {
                    b.Navigation("AddAssets");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.CpuType", b =>
                {
                    b.Navigation("AddAssets");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.HarddiscType", b =>
                {
                    b.Navigation("AddAssets");
                });

            modelBuilder.Entity("AssetManagementSystemAPI.Model.RamType", b =>
                {
                    b.Navigation("AddAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
