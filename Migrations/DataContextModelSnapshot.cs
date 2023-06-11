﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_programlama.Models;

#nullable disable

namespace Web_programlama.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web_programlama.Models.Admin", b =>
                {
                    b.Property<int>("a_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("a_id"));

                    b.Property<string>("a_soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("a_tc")
                        .HasColumnType("int");

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sifre")
                        .HasColumnType("int");

                    b.HasKey("a_id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Web_programlama.Models.Depremzede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("aile_no")
                        .HasColumnType("int");

                    b.Property<string>("cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("istek_no")
                        .HasColumnType("int");

                    b.Property<int>("sifre")
                        .HasColumnType("int");

                    b.Property<string>("soyisim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tc_no")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Depremzedes");
                });

            modelBuilder.Entity("Web_programlama.Models.Gonullu", b =>
                {
                    b.Property<int>("g_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("g_id"));

                    b.Property<int>("g_tc")
                        .HasColumnType("int");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meslegi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sifre")
                        .HasColumnType("int");

                    b.Property<string>("soyisim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.Property<string>("yasi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("g_id");

                    b.ToTable("Gonullus");
                });

            modelBuilder.Entity("Web_programlama.Models.Haber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Habers");
                });

            modelBuilder.Entity("Web_programlama.Models.Kullanici", b =>
                {
                    b.Property<int>("k_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("k_id"));

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("k_tc")
                        .HasColumnType("int");

                    b.Property<string>("k_yetki_turu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sifre")
                        .HasColumnType("int");

                    b.HasKey("k_id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("Web_programlama.Models.ToplanmaAlani", b =>
                {
                    b.Property<int>("a_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("a_id"));

                    b.Property<string>("a_adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("a_kodu")
                        .HasColumnType("int");

                    b.Property<string>("a_niteligi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("a_tcsi")
                        .HasColumnType("int");

                    b.HasKey("a_id");

                    b.ToTable("Toplanma_Alanis");
                });

            modelBuilder.Entity("Web_programlama.Models.Urun", b =>
                {
                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("adet")
                        .HasColumnType("int");

                    b.HasKey("isim");

                    b.ToTable("uruns");
                });

            modelBuilder.Entity("Web_programlama.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Web_programlama.Models.Yetkili", b =>
                {
                    b.Property<int>("y_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("y_id"));

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sifre")
                        .HasColumnType("int");

                    b.Property<string>("y_d_tarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("y_tc")
                        .HasColumnType("int");

                    b.HasKey("y_id");

                    b.ToTable("Yetkilis");
                });

            modelBuilder.Entity("Web_programlama.Models.İhtiyac", b =>
                {
                    b.Property<int>("i_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("i_id"));

                    b.Property<string>("i_adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("i_miktari")
                        .HasColumnType("int");

                    b.Property<string>("istek_adresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ozel_istek")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("i_id");

                    b.ToTable("ihtiyaclars");
                });
#pragma warning restore 612, 618
        }
    }
}
