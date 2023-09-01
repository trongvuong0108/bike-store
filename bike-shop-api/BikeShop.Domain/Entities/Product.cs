using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain.Entities
{
    [Table("products",Schema = "production")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { set; get; }

        [Required]
        [StringLength(50)]
        [Column("product_name")]
        public string Name { set; get; }

        [StringLength(50)]
        [Column("model_year")]
        public Int16 ModelYear { set; get; }

        [StringLength(50)]
        [Column("list_price")]
        public decimal ListPrice { set; get; }
    }
}
