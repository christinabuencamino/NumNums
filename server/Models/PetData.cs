using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
	[Table("PetData")]
	public class PetData
	{
        public PetData()
        {
        }

		
        [Column("pet_id")]
        public string PetDataId { get; set; }
        [Column("user_id")]
        public string UserId { get; set; }
        
        [Column("pet_name")]
		public string PetName { get; set; }
		
		[Column("petttype_id")]
		public string PtypeId { get; set; }
		[Column("petgender_id")]
		public string GenderId { get; set; }
		[Column("pet_dob")]
		public DateTime PetDOB { get; set; }
		[Column("foodtype_id")]
		public string FoodPreference { get; set; }
	}
}

