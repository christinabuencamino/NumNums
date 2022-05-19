using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        public OrderDetails(){}
        
        [Column("od_id")]
        public string OrderDetailsId { get; set; }
        
        [Column("user_id")]
        public string UserId { get; set; }
        
        [Column("total")]
        public int TotalAmount { get; set;  }
        
        [Column("pd_id")]
        public string ProductId { get; set; }
        
        [Column("created_at")]
        public string CreatedAt { get; set; }
        
        [Column("modified_at")]
        public string ModifiedAt { get; set;  }

    }
}