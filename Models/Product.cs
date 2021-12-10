using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIInvoice.Models
{
    public class Product
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string productId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string category { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string sellprice { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string invoiceId { get; set; }
    }
}