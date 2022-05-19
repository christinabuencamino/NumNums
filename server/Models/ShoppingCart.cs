using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace server.Models
{
    [Table("CartItem")]
	
    public class ShoppingCart
    {
        public ShoppingCart(){}

        [Column("cart_id")]
        public string ShoppingCartId { get; set; }
        [Column("session_id")]
        public string SessionId { get; set; }
        [Column("prod_id")]
        public string ProductId { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("created_at")]
        public string CreatedAt { get; set; }
        [Column("modified_at")]
        public string ModifiedAt { get; set; }
    }
}