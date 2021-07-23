using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoFoodApI.Entities
{
    [Table("Admin")]
    public class Admin
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(Order = 100, TypeName = "serial")]
        public int? Userid { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [Column(TypeName = "Bigint")]
        public int? Mobile { get; set; }
    }
}