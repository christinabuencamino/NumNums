using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("Order")]
    public class Order
    {
        public Order(){}

        [Column("order_id")] 
        public string OrderId { get; set; }
        
        [Column("od_id")]
        public string OrderDetailsId { get; set; }
        
        [Column("prod_id")]
        public string ProductId { get; set; }
        
        [Column("created_at")]
        public string CreatedAt { get; set; }
        
        [Column("modified_at")]
        public string ModifiedAt { get; set; }
        



    }
}