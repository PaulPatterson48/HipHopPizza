using System;
namespace HipHopPizzaWings.Models
{
	public class Item
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public string ItemName { get; set; }
		public decimal ItemPrice { get; set; }
	}

}

