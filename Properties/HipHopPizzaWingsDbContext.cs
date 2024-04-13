using System;
using Microsoft.EntityFrameworkCore;
using HipHopPizzaWings.Models;
using HipHopPizzaWings.Data;


namespace HipHopPizzaWings 
{
	public class HipHopPizzaWingsDbContext : DbContext
	{
		public DbSet<Order> Orders { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<OrderType> OrderTypes { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }
		public DbSet<Cashier> Cashiers { get; set; }


		public HipHopPizzaWingsDbContext(DbContextOptions<HipHopPizzaWingsDbContext> context) : base(context)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Order>().HasData(OrderData.Orders);
			modelBuilder.Entity<Item>().HasData(ItemData.Items);
			modelBuilder.Entity<OrderItem>().HasData(OrderItemData.OrderItems);
			modelBuilder.Entity<OrderType>().HasData(OrderTypeData.OrderTypes);
			modelBuilder.Entity<PaymentType>().HasData(PaymentTypeData.PaymentTypes);
		}
	}
}

