using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day5_MVC_ITI.Models
{


    [Table("Customer")]
    public class Customer
    {
        
        [Key]
        [Required(ErrorMessage = "Id is a Required Field")]
        [Range(0,1000000)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required")]
        [InValues(new string[] { "F", "M" }, ErrorMessage = "must only be F for female or M for male")]
        [MaxLength(1, ErrorMessage ="must only be F for female or M for male")]
        public String Gender { get; set; }
        [Column("Name")]
        [Required(ErrorMessage = "Name is a Required Field")]
        public String Name { get; set; }
        [MaxLength(80, ErrorMessage = "Maximum character limit exceeded")]
        [Column("Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Column("Phone")]
        [Required(ErrorMessage = "Phone is a Required Field")]
        [DataType(DataType.PhoneNumber)]
        [MinLength(11, ErrorMessage = "must be 11 digits")]
        [MaxLength(11, ErrorMessage = "must be 11 digits")]

        public String Phone { get; set; }

        public List<Order> Orders { get; set; }
    }
}