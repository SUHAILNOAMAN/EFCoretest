﻿// <auto-generated />
using EF_Core_test.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core_test.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230126093210_intiDB")]
    partial class intiDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_Core_test.Model.CardStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("CardStudent");
                });

            modelBuilder.Entity("EF_Core_test.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CardStudentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardStudentId")
                        .IsUnique();

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EF_Core_test.Model.Student", b =>
                {
                    b.HasOne("EF_Core_test.Model.CardStudent", "CardStudent")
                        .WithOne("Student")
                        .HasForeignKey("EF_Core_test.Model.Student", "CardStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardStudent");
                });

            modelBuilder.Entity("EF_Core_test.Model.CardStudent", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
