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
		public DbSet<Cashier> Cahsiers { get; set; }
	}

	public HipHopPizzaWingsDbContext(DbContextOptions<HipHopPizzaWingsDbContext> options) : base(options)
	{

	}

	protected overtider void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Order>().HasData(OrderData.Orders);
		modelBuilder.Entity<Item>().HasData(ItemData.Items);
		modelBuilder.Entity<OrderItem>().HasData(OrderData.OrderItems)
	}
}

