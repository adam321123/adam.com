using Microsoft.EntityFrameworkCore;

namespace APIInvoice.Models
{
    public class dbInvoiceContext : DbContext
    {
        public dbInvoiceContext(DbContextOptions<dbInvoiceContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}