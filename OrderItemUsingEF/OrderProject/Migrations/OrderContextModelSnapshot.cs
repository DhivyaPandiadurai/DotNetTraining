﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderProject.Context;

namespace OrderProject.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderProject.Models.Item", b =>
                {
                    b.Property<int>("Iid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Iname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Iid");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Iid = 1,
                            Iname = "Nippon Blobby",
                            Price = 200
                        },
                        new
                        {
                            Iid = 2,
                            Iname = "Smiley",
                            Price = 250
                        });
                });

            modelBuilder.Entity("OrderProject.Models.Order", b =>
                {
                    b.Property<int>("Orderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Iid")
                        .HasColumnType("int");

                    b.Property<DateTime>("ODate")
                        .HasColumnType("datetime2");

                    b.HasKey("Orderid");

                    b.HasIndex("Iid");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Orderid = 1,
                            DDate = new DateTime(2019, 11, 19, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(4738),
                            Iid = 1,
                            ODate = new DateTime(2019, 11, 12, 17, 20, 49, 489, DateTimeKind.Local).AddTicks(3038)
                        },
                        new
                        {
                            Orderid = 2,
                            DDate = new DateTime(2019, 11, 19, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(6304),
                            Iid = 2,
                            ODate = new DateTime(2019, 11, 12, 17, 20, 49, 490, DateTimeKind.Local).AddTicks(6277)
                        });
                });

            modelBuilder.Entity("OrderProject.Models.Order", b =>
                {
                    b.HasOne("OrderProject.Models.Item", "Item")
                        .WithMany("Orders")
                        .HasForeignKey("Iid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
