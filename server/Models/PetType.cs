using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace server.Models
{
	[Table("PetType")]
	public class PetType
	{
		public PetType()
		{
		}
		
		[Column("ptype_id")]
		public string PetTypeId { get; set; }
		[Column("pet_type")]
		public string Type { get; set; }
		[Column("isActive")]
		public int IsActive { get; set; }
	}
}

