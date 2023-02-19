﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticketing.Infrastructure.EFCore;

#nullable disable

namespace Ticketing.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(TicketingContext))]
    [Migration("20230219130655_AddFormTable")]
    partial class AddFormTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ticketing.Domain.FormAgg.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Forms", (string)null);
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaAgg.FormSchema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId")
                        .IsUnique();

                    b.ToTable("FormSchemas", (string)null);
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaFieldAgg.FormSchemaField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("FormSchemaId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormSchemaId");

                    b.ToTable("FormSchemasFields", (string)null);
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaTypeAgg.FormSchemaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("FormSchemaTypes", (string)null);
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaAgg.FormSchema", b =>
                {
                    b.HasOne("Ticketing.Domain.FormSchemaTypeAgg.FormSchemaType", "Type")
                        .WithOne("Schema")
                        .HasForeignKey("Ticketing.Domain.FormSchemaAgg.FormSchema", "TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaFieldAgg.FormSchemaField", b =>
                {
                    b.HasOne("Ticketing.Domain.FormSchemaAgg.FormSchema", "FormSchema")
                        .WithMany("Fields")
                        .HasForeignKey("FormSchemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormSchema");
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaAgg.FormSchema", b =>
                {
                    b.Navigation("Fields");
                });

            modelBuilder.Entity("Ticketing.Domain.FormSchemaTypeAgg.FormSchemaType", b =>
                {
                    b.Navigation("Schema")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
