using System;
using System.ComponentModel.DataAnnotations; 

namespace HipHopPizzaWings.Models
{
	public class Cashier
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string email { get; set; }
		public string uid { get; set; }
	}
}

