using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day5_MVC_ITI.Models
{
    public class Order
    {
        [Column("id", TypeName = "int")]
        [Key]
        [Required(ErrorMessage = "Id is a Required Field")]
        [Range(0, 1000000)]
        public int ID { get; set; }
        [Column("date", TypeName = "date")]
        [Required(ErrorMessage = "Order Date is a Required Field")]
       
        public DateTime Date { get; set; }
        [Column("totalPrice", TypeName = "money")]
        
        [Required(ErrorMessage = "Price is a Required Field")]
        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        [Range(0, 1000000)]
        public int CustID { get; set; }

        public Customer Customer { get; set;}
    }
}