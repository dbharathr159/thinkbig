using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoFoodApI.Entities
{
    [Table("OrderItem")]
    public class OrderItem
    {
        

        public int? Orderid { get; set; }
        [ForeignKey("Orderid")]//set foreign key constraint
        public Order Order { get; set; }
        public int? Menuid { get; set; }
        [ForeignKey("Menuid")]//set foreign key constraint

        public Menu Menu { get; set; }

        [Column(TypeName = "Decimal")]
        public double Amount { get; set; }
        
        public int? NoofServing { get; set; }
        [Column(TypeName = "Decimal")]
        public double Total { get; set; }
        
        

    }
}
