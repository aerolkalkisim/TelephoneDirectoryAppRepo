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
    [Migration("20210814125929_foreignkey2")]
    partial class foreignkey2
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("TypeId");

                    b.ToTable("ContactInformations");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformationType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ContactInformationType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4fe6287-6888-44e1-a342-2eb1835bc944"),
                            Name = "Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("15f5add5-e734-4959-8ad3-ef172731a181"),
                            Name = "Ev Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("845645f8-612f-4503-9b7e-7990446cec17"),
                            Name = "İşyeri Telefon Numarası"
                        },
                        new
                        {
                            Id = new Guid("d681d810-6d0c-45da-a0a7-3aa837fceb82"),
                            Name = "Email"
                        },
                        new
                        {
                            Id = new Guid("949e29e9-7e22-4215-9c4c-b99855ecb5f3"),
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

                    b.HasOne("TelephoneDirectoryApp.Model.Entity.ContactInformationType", "Type")
                        .WithMany("ContactInformations")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.Contact", b =>
                {
                    b.Navigation("ContactInformations");
                });

            modelBuilder.Entity("TelephoneDirectoryApp.Model.Entity.ContactInformationType", b =>
                {
                    b.Navigation("ContactInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
