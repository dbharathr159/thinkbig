using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoFoodApI.Entities
{
    [Table("Payment")]
    public class Payment
    {

        [Key]//set Primary key constraint
        public int? Paymentid { get; set; }

        public int Orderid { get; set; }
        [ForeignKey("Oredrid")]//set foreign key constraint
        public Order Order { get; set; }

        [Column(TypeName = "Decimal")]
        public double TotalAmount { get; set; }
        [StringLength(20)]
        public string PaidBy { get; set; }
        [StringLength(20)]
        public string Status { get; set; }

        
        
    }
}
