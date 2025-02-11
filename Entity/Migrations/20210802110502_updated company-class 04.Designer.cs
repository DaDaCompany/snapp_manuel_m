﻿// <auto-generated />
using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entity.Migrations
{
    [DbContext(typeof(CoreContext))]
    [Migration("20210802110502_updated company-class 04")]
    partial class updatedcompanyclass04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Core.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ContactdataId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.Property<string>("Town")
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContactdataId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Core.Article", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ArticleCategory")
                        .HasColumnType("longtext");

                    b.Property<string>("ArticleHistoryId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("PricePerUnit")
                        .HasColumnType("double");

                    b.Property<int>("TaxRate")
                        .HasColumnType("int");

                    b.Property<string>("UnitMeasurement")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArticleHistoryId");

                    b.ToTable("ArticleList");
                });

            modelBuilder.Entity("Core.ArticleHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<int>("ArticleCategory")
                        .HasColumnType("int");

                    b.Property<string>("ArticleDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("ArticleName")
                        .HasColumnType("longtext");

                    b.Property<double>("ArticlePricePerUnit")
                        .HasColumnType("double");

                    b.Property<int>("ArticleTaxRate")
                        .HasColumnType("int");

                    b.Property<string>("ArticleUnitMeasurement")
                        .HasColumnType("longtext");

                    b.Property<string>("BaseArticleId")
                        .HasColumnType("longtext");

                    b.Property<double>("Discount")
                        .HasColumnType("double");

                    b.Property<string>("ProjectId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ArticleHistory");
                });

            modelBuilder.Entity("Core.Bill", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ContactdataId")
                        .HasColumnType("longtext");

                    b.Property<string>("Logo")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentRidge")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("AdressId")
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Contactdatas");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ContactdataId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Firstname")
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContactdataId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Core.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ArticleHistoryId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("BillId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.Property<string>("Town")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArticleHistoryId");

                    b.HasIndex("BillId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ProjectList");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Address", b =>
                {
                    b.HasOne("Core.Contactdata", null)
                        .WithMany("Address")
                        .HasForeignKey("ContactdataId");
                });

            modelBuilder.Entity("Core.Article", b =>
                {
                    b.HasOne("Core.ArticleHistory", null)
                        .WithMany("BaseArticles")
                        .HasForeignKey("ArticleHistoryId");
                });

            modelBuilder.Entity("Core.Bill", b =>
                {
                    b.HasOne("Core.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.HasOne("Core.Company", null)
                        .WithMany("Contactdata")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.HasOne("Core.Contactdata", "Contactdata")
                        .WithMany()
                        .HasForeignKey("ContactdataId");

                    b.Navigation("Contactdata");
                });

            modelBuilder.Entity("Core.Project", b =>
                {
                    b.HasOne("Core.ArticleHistory", null)
                        .WithMany("Projects")
                        .HasForeignKey("ArticleHistoryId");

                    b.HasOne("Core.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");

                    b.HasOne("Core.Customer", "Customer")
                        .WithMany("Projects")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Bill");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.HasOne("Core.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Core.Project", "Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Company");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Core.ArticleHistory", b =>
                {
                    b.Navigation("BaseArticles");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.Navigation("Contactdata");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Core.Project", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
