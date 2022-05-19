using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
	[Table("UserData")]
	public class UserData
	{
		public UserData()
		{
		}

		[Column("user_id")]
		public string UserDataId { get; set; }
		[Column("first_name")]
		public string FirstName { get; set; }
		[Column("last_name")]
		public string LastName { get; set; }
		[Column("phone_number")]
		public string Phone { get; set; }
		
		[Column("email")]
		public string Email { get; set; }
		
		[Column("password")]
		public string Password { get; set; }
		
		[Column("street")]
		public string Street { get; set; }
		[Column("city")]
		public string City { get; set; }
		[Column("state")]
		public string State { get; set; }
		[Column("zipcode")]
        public int Zipcode { get; set; }
	}
}

