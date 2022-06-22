﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionMicroservice;

namespace TransactionMicroservice.Migrations
{
    [DbContext(typeof(TransactionContext))]
    [Migration("20211012041621_Initial_Transaction")]
    partial class Initial_Transaction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransactionMicroservice.Models.Statement", b =>
                {
                    b.Property<int>("StatementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("ClosingBalance")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<string>("Narration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatementId");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("TransactionMicroservice.Models.TransactionHistory", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<double>("TransactionAmount")
                        .HasColumnType("float");

                    b.Property<double>("destination_balance")
                        .HasColumnType("float");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("source_balance")
                        .HasColumnType("float");

                    b.HasKey("TransactionId");

                    b.ToTable("TransactionHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
