﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TelephoneDirectoryApp.Data.DataContext;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20210814131238_foreignkey5")]
    partial class foreignkey5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Firm")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContactInformationTypeId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("ContactInformationTypeId");

                    b.ToTable("ContactInformations");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformationType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("TypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("ContactInformationType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2e5d7fb-87d4-442b-8080-f518ef404cee"),
                            Name = "Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("6cb36c9e-10a3-4b61-b6d5-d03ef029db74"),
                            Name = "Ev Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("089115d9-52d9-46ba-aedb-cbd7c55eb619"),
                            Name = "İşyeri Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("d8282447-66ce-4f5c-aa71-d6bcc8debe51"),
                            Name = "Email"
                        },
                        new
                        {
                            Id = new Guid("862b8ef8-79c2-497e-9ed7-2943a4f50949"),
                            Name = "Konum"
                        });
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformation", b =>
                {
                    b.HasOne("TelephoneDirectoryApp.Model.Entity.Contact", "Contact")
                        .WithMany("ContactInformations")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TelephoneDirectoryApp.Model.Entity.ContactInformationType", "ContactInformationType")
                        .WithMany()
                        .HasForeignKey("ContactInformationTypeId");

                    b.Navigation("Contact");

                    b.Navigation("ContactInformationType");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformationType", b =>
                {
                    b.HasOne("TelephoneDirectoryApp.Model.Entity.ContactInformationType", null)
                        .WithMany("ContactInformationTypes")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.Contact", b =>
                {
                    b.Navigation("ContactInformations");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformationType", b =>
                {
                    b.Navigation("ContactInformationTypes");
                });
#pragma warning restore 612, 618
        }
    }
}