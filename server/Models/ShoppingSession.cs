using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace server.Models{

    [Table("ShoppingSession")]
    public class ShoppingSession
    {
        public ShoppingSession(){}
        
        [Column("session_id")] 
        public string ShoppingSessionId { get; set; }
        
        [Column("user_id")]
        public string UserId { get; set; }
        
        [Column("total")]
        public string Total { get; set; }
        
        [Column("created_at")]
        public string CreatedAt { get; set; }
        
        [Column("modified_at")]
        public string ModifiedAt { get; set; }
        
        
    }
}