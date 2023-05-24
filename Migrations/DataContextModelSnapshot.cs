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

                    b.Property<string>("a_isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("a_sifre")
                        .HasColumnType("int");

                    b.Property<string>("a_soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("a_tc")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("aile_no")
                        .HasColumnType("int");

                    b.Property<string>("cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("istek_no")
                        .HasColumnType("int");

                    b.Property<string>("soyisim")
                        .IsRequired()
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

                    b.Property<string>("sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyisim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.Property<string>("yasi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("g_id");

                    b.ToTable("Gonullus");
                });

            modelBuilder.Entity("Web_programlama.Models.Haberler", b =>
                {
                    b.Property<int>("h_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("h_id"));

                    b.Property<string>("gida_dagitim_noktalari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("saglik_merkezleri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("son_haberler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("h_id");

                    b.ToTable("Haberlers");
                });

            modelBuilder.Entity("Web_programlama.Models.Ihtiyaclar", b =>
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

            modelBuilder.Entity("Web_programlama.Models.Kullanici", b =>
                {
                    b.Property<int>("k_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("k_id"));

                    b.Property<string>("k_adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("k_sifre")
                        .HasColumnType("int");

                    b.Property<int?>("k_tc")
                        .HasColumnType("int");

                    b.Property<string>("k_yetki_turu")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Web_programlama.Models.Yetkili", b =>
                {
                    b.Property<int>("y_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("y_id"));

                    b.Property<string>("y_d_tarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("y_soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("y_tc")
                        .HasColumnType("int");

                    b.HasKey("y_id");

                    b.ToTable("Yetkilis");
                });
#pragma warning restore 612, 618
        }
    }
}
