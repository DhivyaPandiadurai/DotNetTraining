﻿// <auto-generated />
using System;
using EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCore.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCore.Models.Dept", b =>
                {
                    b.Property<string>("Did")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Did");

                    b.ToTable("Dept");
                });

            modelBuilder.Entity("EntityFrameworkCore.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desig")
                        .HasColumnName("Designation")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Did")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sal")
                        .HasColumnName("Salary")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.HasIndex("Did");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EntityFrameworkCore.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("School")
                        .HasColumnName("Std")
                        .HasColumnType("varchar(16)");

                    b.Property<DateTime?>("joinDate")
                        .HasColumnType("Date");

                    b.HasKey("ID");

                    b.ToTable("Student1");
                });

            modelBuilder.Entity("EntityFrameworkCore.Models.Employee", b =>
                {
                    b.HasOne("EntityFrameworkCore.Models.Dept", "Dept")
                        .WithMany("Employees")
                        .HasForeignKey("Did");
                });
#pragma warning restore 612, 618
        }
    }
}
