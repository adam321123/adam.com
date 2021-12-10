using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIInvoice.Migrations
{
    public partial class Invoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer = table.Column<string>(type: "varchar(10)", nullable: false),
                    name = table.Column<string>(type: "varchar(200)", nullable: true),
                    address = table.Column<string>(type: "varchar(200)", nullable: true),
                    city = table.Column<string>(type: "varchar(100)", nullable: true),
                    phone = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    invoiceId = table.Column<string>(type: "varchar(10)", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    customer = table.Column<string>(type: "varchar(10)", nullable: true),
                    productId = table.Column<string>(type: "varchar(10)", nullable: true),
                    category = table.Column<string>(type: "varchar(100)", nullable: true),
                    sellprice = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.invoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_customer",
                        column: x => x.customer,
                        principalTable: "Customers",
                        principalColumn: "customer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<string>(type: "varchar(10)", nullable: false),
                    category = table.Column<string>(type: "varchar(100)", nullable: true),
                    sellprice = table.Column<string>(type: "varchar(100)", nullable: true),
                    invoiceId = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Invoices_invoiceId",
                        column: x => x.invoiceId,
                        principalTable: "Invoices",
                        principalColumn: "invoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_customer",
                table: "Invoices",
                column: "customer");

            migrationBuilder.CreateIndex(
                name: "IX_Products_invoiceId",
                table: "Products",
                column: "invoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
