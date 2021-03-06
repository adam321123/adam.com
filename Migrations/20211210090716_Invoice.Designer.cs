// <auto-generated />
using System;
using APIInvoice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIInvoice.Migrations
{
    [DbContext(typeof(dbInvoiceContext))]
    [Migration("20211210090716_Invoice")]
    partial class Invoice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIInvoice.Models.Customer", b =>
                {
                    b.Property<string>("customer")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("address")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("city")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("name")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("phone")
                        .HasColumnType("varchar(20)");

                    b.HasKey("customer");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("APIInvoice.Models.Invoice", b =>
                {
                    b.Property<string>("invoiceId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("category")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("customer")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("date")
                        .HasColumnType("date");

                    b.Property<string>("productId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("sellprice")
                        .HasColumnType("varchar(100)");

                    b.HasKey("invoiceId");

                    b.HasIndex("customer");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("APIInvoice.Models.Product", b =>
                {
                    b.Property<string>("productId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("category")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("invoiceId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("sellprice")
                        .HasColumnType("varchar(100)");

                    b.HasKey("productId");

                    b.HasIndex("invoiceId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("APIInvoice.Models.Invoice", b =>
                {
                    b.HasOne("APIInvoice.Models.Customer", null)
                        .WithMany("Invoices")
                        .HasForeignKey("customer");
                });

            modelBuilder.Entity("APIInvoice.Models.Product", b =>
                {
                    b.HasOne("APIInvoice.Models.Invoice", null)
                        .WithMany("Products")
                        .HasForeignKey("invoiceId");
                });

            modelBuilder.Entity("APIInvoice.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("APIInvoice.Models.Invoice", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
