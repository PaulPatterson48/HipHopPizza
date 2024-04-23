using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace HipHopPizzaWings.Models
{
	public class OrderItem
	{
		public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
		public int ItemId { get; set; }
		public int Quantity { get; set; }
	
	}
}

