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
				entity.Property(e => e.Type).IsRequired();
				entity.Property(e => e.IsActive).IsRequired();


			});
			modelBuilder.Entity<UserData>(entity =>
			{
				entity.HasKey(e => e.UserDataId);
				// entity.ToTable("UserData");
				entity.Property(e => e.FirstName).IsRequired();
				entity.Property(e => e.LastName).IsRequired();
				entity.Property(e => e.Email).IsRequired();
				entity.Property(e => e.Password).IsRequired();
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
				entity.Property(e => e.PetDOB).IsRequired();
				entity.Property(e => e.FoodPreference).IsRequired();
			});
			modelBuilder.Entity<PetGender>(entity =>
			{
				entity.HasKey((e => e.PetGenderId));
				// entity.ToTable("PetGender");
				entity.Property(e => e.Gender).IsRequired();
			});
            modelBuilder.Entity<Food>(entity =>
            {
	            entity.HasKey(e => e.FoodId);
	            // entity.ToTable("Food");
	            entity.Property(e => e.FoodKind).IsRequired();
            });
            modelBuilder.Entity<Product>(entity =>
            {
	            entity.HasKey(e => e.ProductId);
	            // entity.ToTable("Food");
	            entity.Property(e => e.ProductName).IsRequired();
	            entity.Property(e => e.ProductTypeId).IsRequired();
	            entity.Property(e => e.FoodId).IsRequired();
	            entity.Property(e => e.FoodPrice).IsRequired();
	            entity.Property(e => e.ProductStock).IsRequired();
	            entity.Property(e => e.ProductLink).IsRequired();
            });
            modelBuilder.Entity<WebLink>(entity =>
            {
	            entity.HasKey(e => e.WebLinkId);
	            entity.Property(e => e.WebsiteLink);
            });
            
            modelBuilder.Entity<ShoppingCart>(entity=>
            {
	            entity.HasKey(e => e.ShoppingCartId);
	            entity.Property(e => e.SessionId).IsRequired();
	            entity.Property(e => e.ProductId).IsRequired();
	            entity.Property(e => e.Quantity).IsRequired();
	            entity.Property(e => e.CreatedAt).IsRequired();
	            entity.Property(e => e.ModifiedAt).IsRequired();

            });

            modelBuilder.Entity<Order>(entity =>
            {
	            entity.HasKey(e => e.OrderId);
	            entity.Property(e => e.OrderDetailsId).IsRequired();
	            entity.Property(e => e.ProductId).IsRequired();
	            entity.Property(e => e.CreatedAt).IsRequired();
	            entity.Property(e => e.ModifiedAt).IsRequired();

            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
	            entity.HasKey(e => e.OrderDetailsId);
	            entity.Property(e => e.UserId).IsRequired();
	            entity.Property(e => e.TotalAmount).IsRequired();
	            entity.Property(e => e.ProductId).IsRequired();
	            entity.Property(e => e.CreatedAt).IsRequired();
	            entity.Property(e => e.ModifiedAt).IsRequired();
            });

            modelBuilder.Entity<Payment>(entity =>
            {
	            entity.HasKey(e => e.PaymentDetailsId);
	            entity.Property(e => e.OrderDetailsId).IsRequired();
	            entity.Property(e => e.TotalAmount).IsRequired();
	            entity.Property(e => e.Provider).IsRequired();
	            entity.Property(e => e.Status).IsRequired();
	            entity.Property(e => e.CreatedAt).IsRequired();
	            entity.Property(e => e.ModifiedAt).IsRequired();
            });

            modelBuilder.Entity<ShoppingSession>(entity =>
            {
	            entity.HasKey(e => e.ShoppingSessionId);
	            entity.Property(e => e.UserId).IsRequired();
	            entity.Property(e => e.Total).IsRequired();
	            entity.Property(e => e.CreatedAt).IsRequired();
	            entity.Property(e => e.ModifiedAt).IsRequired();

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

		//seeding data
		public DbSet<WebLink> Links { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<ShoppingSession> ShoppingSession { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderDetails> OrderDetails { get; set; }
		public DbSet<Payment> Payments { get; set;  }
	}
}

