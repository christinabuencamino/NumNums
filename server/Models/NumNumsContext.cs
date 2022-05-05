using System;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Models
{
	public class NumNumsContext: DbContext
	{
		public NumNumsContext(DbContextOptions<NumNumsContext> options): base(options)
		{
		}

		
		public DbSet<Toy> Toys { get; set; }
		public DbSet<PetType> PetTypes { get; set; }
		public DbSet<UserData> UserDatas { get; set; }
		public DbSet<PetData> PetDatas { get; set; }

		//seeding data
		protected override void OnModelCreating(ModelBuilder modelBuilder){
			modelBuilder.Entity<Toy>().ToTable("Toys");
			modelBuilder.Entity<PetType>().ToTable("PetTypes");
			modelBuilder.Entity<UserData>().ToTable("Users");
			modelBuilder.Entity<PetData>().ToTable("PetDatas");


		}
	}
}

