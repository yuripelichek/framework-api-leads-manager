﻿// <auto-generated />
using System;
using Framework.LeadsManager.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Framework.LeadsManager.Infrastructure.Data.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4429),
                            Description = "CategoriaDescription01",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4454),
                            Name = "Categoria01"
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4460),
                            Description = "CategoriaDescription02",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4461),
                            Name = "Categoria02"
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4463),
                            Description = "CategoriaDescription03",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4464),
                            Name = "Categoria03"
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4466),
                            Description = "CategoriaDescription04",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 902, DateTimeKind.Local).AddTicks(4467),
                            Name = "Categoria04"
                        });
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = -6,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 898, DateTimeKind.Local).AddTicks(8097),
                            Email = "nome01@xyz.com",
                            LastName = "Sobrenome01",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 900, DateTimeKind.Local).AddTicks(8857),
                            Name = "Nome01",
                            Phone = "111.000.000"
                        },
                        new
                        {
                            Id = -2,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(47),
                            Email = "nome022@xyz.com",
                            LastName = "Sobrenome022",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(53),
                            Name = "Nome022",
                            Phone = "222222.000.000"
                        },
                        new
                        {
                            Id = -3,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(55),
                            Email = "nome033@xyz.com",
                            LastName = "Sobrenome033",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(56),
                            Name = "Nome033",
                            Phone = "333333.000.000"
                        },
                        new
                        {
                            Id = -4,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(58),
                            Email = "nome044@xyz.com",
                            LastName = "Sobrenome044",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(59),
                            Name = "Nome044",
                            Phone = "444444.000.000"
                        },
                        new
                        {
                            Id = -5,
                            CreatedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(63),
                            Email = "nome044@xyz.com",
                            LastName = "Sobrenome044",
                            ModifiedAt = new DateTime(2022, 9, 26, 23, 57, 49, 901, DateTimeKind.Local).AddTicks(64),
                            Name = "Nome055",
                            Phone = "444444.000.000"
                        });
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PriceWithDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("JobId")
                        .IsUnique();

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Address", b =>
                {
                    b.HasOne("Framework.LeadsManager.Domain.Entities.Client", "Client")
                        .WithOne("Addreess")
                        .HasForeignKey("Framework.LeadsManager.Domain.Entities.Address", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Job", b =>
                {
                    b.HasOne("Framework.LeadsManager.Domain.Entities.Category", "Category")
                        .WithOne("Job")
                        .HasForeignKey("Framework.LeadsManager.Domain.Entities.Job", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Lead", b =>
                {
                    b.HasOne("Framework.LeadsManager.Domain.Entities.Client", "Client")
                        .WithMany("Lead")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Framework.LeadsManager.Domain.Entities.Job", "Job")
                        .WithOne("Lead")
                        .HasForeignKey("Framework.LeadsManager.Domain.Entities.Lead", "JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Category", b =>
                {
                    b.Navigation("Job");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Client", b =>
                {
                    b.Navigation("Addreess");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("Framework.LeadsManager.Domain.Entities.Job", b =>
                {
                    b.Navigation("Lead");
                });
#pragma warning restore 612, 618
        }
    }
}
