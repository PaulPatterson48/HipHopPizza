using System;
using System.Collections;

namespace HipHopPizzaWings.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public int OrderId { get; set; }

		public ICollection<Order>? Orders { get; set; }
		public ICollection<Item>? Items { get; set; }
	}
}

