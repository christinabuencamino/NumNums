using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace server.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            
        }
        [Column("prod_id")]
        public string ProductId { get; set; }
        
        [Column("prod_name")]
        public string ProductName { get; set; }
        
        [Column("ptype_id")]
        public string ProductTypeId { get; set; }
        
        [Column("food_id")]
        public string FoodId { get; set; }
        
        [Column("food_price")]
        public int FoodPrice{ get; set; }
        
        [Column("prod_stock")]
        public int ProductStock{ get; set; }
        
        [Column("prod_link")]
        public string ProductLink{ get; set; }

    }
}