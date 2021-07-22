using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoFoodApI.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]//primary key
        public int? Customerid { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [Column(TypeName = "Bigint")]
        public int? Moblie { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
    }
}
