using System;
namespace server.Models
{
	public class UserData
	{
		public UserData()
		{
		}

		public string UserDataId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zipcode { get; set; }
	}
}

