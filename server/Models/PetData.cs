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
        [Column("pet_name")]
		public string PetName { get; set; }
		[Column("user_id")]
		public string UserId { get; set; }
		[Column("ptype_id")]
		public string PtypeId { get; set; }
		[Column("gender_id")]
		public string GenderId { get; set; }
		[Column("pet_dob")]
		public DateTime PetDOB { get; set; }
		[Column("food_pref")]
		public string FoodPreference { get; set; }
	}
}

