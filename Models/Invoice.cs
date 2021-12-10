using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIInvoice.Models
{
    public class Invoice
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string invoiceId { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string customer { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string productId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string category { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string sellprice { get; set; }

        [ForeignKey("invoiceId")]
        public ICollection<Product> Products { get; set; }
    }
}