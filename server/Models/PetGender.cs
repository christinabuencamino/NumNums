using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace server.Models
{
	[Table("PetGender")]
	public class PetGender
	{
		public PetGender()
		{
		}
		
		[Column("gender_id")]
		public string PetGenderId { get; set; }
		[Column("gender")]
		public string Gender { get; set; }
	}
}

