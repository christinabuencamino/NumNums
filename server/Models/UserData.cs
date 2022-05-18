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
		[Column("user_firstname")]
		public string FirstName { get; set; }
		[Column("user_lastname")]
		public string LastName { get; set; }
		[Column("user_phonenumber")]
		public string Phone { get; set; }
		[Column("user_st_address")]
		public string? Street { get; set; }
		[Column("user_city")]
		public string? City { get; set; }
		[Column("user_state")]
		public string? State { get; set; }
		[Column("user_zipcode")]
        public int? Zipcode { get; set; }
	}
}

