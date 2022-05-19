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
        
        [Column("name")]
        public string ProductName { get; set; }
        
        [Column("pettype_id")]
        public string ProductTypeId { get; set; }
        
        [Column("foodtype_id")]
        public string FoodId { get; set; }
        
        [Column("price")]
        public int FoodPrice{ get; set; }
        
        [Column("stock")]
        public int ProductStock{ get; set; }
        
        [Column("link_id")]
        public string ProductLink{ get; set; }

    }
}