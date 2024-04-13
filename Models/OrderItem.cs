using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace HipHopPizzaWings.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
		[Required]
		public Order Order { get; set; }
		public Item Item { get; set; }
	
	}
}

