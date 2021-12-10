using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIInvoice.Models
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string customer { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string name { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string address { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string city { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string phone { get; set; }

        [ForeignKey("customer")]
        public ICollection<Invoice> Invoices { get; set; }
    }
}