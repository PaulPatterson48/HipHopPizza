using System;
using System.ComponentModel.DataAnnotations;


namespace HipHopPizzaWings.Models
{
	public class Item
	{
		public int Id { get; set; }
		[Required]
		public int? OrderId { get; set; }
		public string? ItemName { get; set; }
		public decimal ItemPrice { get; set; }

		public ICollection<OrderItem>? Order { get; set; }
	}

}

