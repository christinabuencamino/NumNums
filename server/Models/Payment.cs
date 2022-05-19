using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    [Table("PaymentDetails")]
    public class Payment
    {
        public Payment(){}


        [Column("pd_id")]
        public string PaymentDetailsId { get; set; }
        [Column("od_id")]
        public string OrderDetailsId { get; set; }
        [Column("amount")]
        public string TotalAmount { get; set; }
        [Column("provider")]
        public string Provider { get; set; }
        [Column("status")]
        public string Status{ get; set; }
        [Column("created_at")]
        public string CreatedAt{ get; set; }
        [Column("modified_at")]
        public string ModifiedAt{ get; set; }

        
        
        

    }

}