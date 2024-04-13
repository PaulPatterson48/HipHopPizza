using System;
using System.ComponentModel.DataAnnotations;


namespace HipHopPizzaWings.Models
{
	public class OrderType
	{
		public int Id { get; set; }
		[Required]
		public string Type { get; set; }
	}
}

