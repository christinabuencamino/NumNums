using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace server.Models
{
    [Table("FoodType")]
	
    public class FoodType
    {
        public FoodType(){}

        [Column("foodtype_00")]
        public string foodType_wet { get; set; }
        
        [Column("foodtype_01")]
        public string foodType_dry { get; set; }
        
        [Column("foodtype_02")]
        public string foodType_treats { get; set; }
        
    }
}