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
    [Migration("20210802101210_updated project-class again")]
    partial class updatedprojectclassagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("CompanyUser", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("UsersId")
                        .HasColumnType("varchar(36)");

                    b.HasKey("CompanyId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("CompanyUser");
                });

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
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ContactdataId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Logo")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PaymentRidge")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContactdataId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("AdressId")
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contactdatas");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("BillId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ContactdataId")
                        .HasColumnType("longtext");

                    b.Property<string>("Firstname")
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("ProjectId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

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
                        .HasColumnType("longtext");

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

                    b.ToTable("ProjectList");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CustomerProject", b =>
                {
                    b.Property<string>("CustomersId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ProjectsId")
                        .HasColumnType("varchar(36)");

                    b.HasKey("CustomersId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("CustomerProject");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<string>("ProjectsId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("UsersId")
                        .HasColumnType("varchar(36)");

                    b.HasKey("ProjectsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("CompanyUser", b =>
                {
                    b.HasOne("Core.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Core.Company", b =>
                {
                    b.HasOne("Core.Contactdata", "Contactdata")
                        .WithMany()
                        .HasForeignKey("ContactdataId");

                    b.Navigation("Contactdata");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.HasOne("Core.Customer", null)
                        .WithMany("Contactdata")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.HasOne("Core.Bill", null)
                        .WithMany("Customers")
                        .HasForeignKey("BillId");
                });

            modelBuilder.Entity("Core.Project", b =>
                {
                    b.HasOne("Core.ArticleHistory", null)
                        .WithMany("Projects")
                        .HasForeignKey("ArticleHistoryId");

                    b.HasOne("Core.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("CustomerProject", b =>
                {
                    b.HasOne("Core.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("Core.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.ArticleHistory", b =>
                {
                    b.Navigation("BaseArticles");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Core.Bill", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Core.Contactdata", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("Core.Customer", b =>
                {
                    b.Navigation("Contactdata");
                });
#pragma warning restore 612, 618
        }
    }
}
