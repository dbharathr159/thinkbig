using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace DemoFoodApI.Entities
{
    [Table("OrderItem")]
    
    public class OrderItem
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? OrderItemId { get; set; }

        public int? Orderid { get; set; }
        [ForeignKey("Orderid")]//set foreign key constraint
        private Orders Orders1 { get; set; }
        public int? Menuid { get; set; }
        [ForeignKey("Menuid")]//set foreign key constraint

        private Menu Menu { get; set; }

        [Column(TypeName = "Decimal")]
        public double Amount { get; set; }
        
        public int? NoofServing { get; set; }
        [Column(TypeName = "Decimal")]
        public double Total { get; set; }
        
        

    }
}
