using System;
namespace server.Models
{
	public class PetData
	{
        public PetData()
        {
        }

        public string PetDataId { get; set; }
		public string PetName { get; set; }
		public string UserId { get; set; }
		public string PtypeId { get; set; }
		public string GenderId { get; set; }
		public DateTime PetDOB { get; set; }
		public string FoodPeference { get; set; }
	}
}

