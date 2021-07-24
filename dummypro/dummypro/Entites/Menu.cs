using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoFoodApI.Entities
{
    [Table("Menu")]
    public class Menu
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Menuid { get; set; }
        [StringLength(20)]
        public string MenuName { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "Decimal")]
        public double Price { get; set; }
        [StringLength(20)]
        public string FoodCategory { get; set; }
    }
}