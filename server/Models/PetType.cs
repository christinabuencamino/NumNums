using System;
namespace server.Models
{
	public class PetType
	{
		public PetType()
		{
		}

		public string PetTypeId { get; set; }
		public string Type { get; set; }
		public int IsActive { get; set; }
	}
}

