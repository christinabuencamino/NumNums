using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
// using Microsoft.EntityFrameworkCore.Metadata;

using server.Models;

namespace server.Models
{
	public class NumNumsContext: DbContext
	{
		public NumNumsContext(DbContextOptions<NumNumsContext> options): base(options)
		{
			
		}


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlite("Data Source=../database/PetStore.db");
			// optionsBuilder.UseSQLite("Data Source=./PetECommerce.db");
		}

		

		//seeding data
		protected override void OnModelCreating(ModelBuilder modelBuilder){
			modelBuilder.Entity<PetType>(entity =>
			{
				entity.HasKey(e => e.PetTypeId);
				// entity.ToTable("PetType");
				entity.Property(e => e.Type).HasColumnName("p_type_id").IsRequired();
				entity.Property(e => e.IsActive).HasColumnName("isActive");


			});
			modelBuilder.Entity<UserData>(entity =>
			{
				entity.HasKey(e => e.UserDataId);
				// entity.ToTable("UserData");
				entity.Property(e => e.FirstName).IsRequired();
				entity.Property(e => e.LastName).IsRequired();
				entity.Property(e => e.Phone).IsRequired();
				entity.Property(e => e.Street).IsRequired();
				entity.Property(e => e.City).IsRequired();
				entity.Property(e => e.State).IsRequired();
				entity.Property(e => e.Zipcode).IsRequired();
			});
			modelBuilder.Entity<PetData>(entity =>
			{
				entity.HasKey(e => e.PetDataId);
				// entity.ToTable("PetData");
				entity.Property(e => e.UserId).IsRequired();
				entity.Property(e => e.PetName).IsRequired();
				entity.Property(e => e.PtypeId).IsRequired();
				entity.Property(e => e.GenderId).IsRequired();
				entity.Property(e => e.GenderId).IsRequired();
				entity.Property(e => e.PetDOB).IsRequired();
				entity.Property(e => e.FoodPreference).IsRequired();
			});
			modelBuilder.Entity<PetGender>(entity =>
			{
				entity.HasKey((e => e.PetGenderId));
				// entity.ToTable("PetGender");
				entity.Property(e => e.PetGenderId).IsRequired();
			});
            modelBuilder.Entity<Food>(entity =>
            {
	            entity.HasKey(e => e.FoodId);
	            // entity.ToTable("Food");
	            entity.Property(e => e.FoodType).IsRequired();
            });
            modelBuilder.Entity<Product>(entity =>
            {
	            entity.HasKey(e => e.ProductId);
	            // entity.ToTable("Food");
	            entity.Property(e => e.ProductName);
	            entity.Property(e => e.ProductTypeId).IsRequired();
	            entity.Property(e => e.FoodId).IsRequired();
	            entity.Property(e => e.FoodPrice);
	            entity.Property(e => e.ProductStock);
	            entity.Property(e => e.ProductLink);
            });


		}
		
		public DbSet<PetType> PetTypes { get; set; }
		public DbSet<UserData> UserDatas { get; set; }
		public DbSet<PetData> PetDatas { get; set; }
		
		public DbSet<Food> Foods { get; set; }
		
		//seeding data
		public DbSet<PetGender> PetGender { get; set; }

		//seeding data
		public DbSet<Product> Products { get; set; }
	}
}

