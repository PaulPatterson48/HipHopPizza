using System;
namespace HipHopPizzaWings.Models
{
	public class Order
	{
		public int Id { get; set; }
		public bool IsPhone { get; set; }
		public string OrderType { get; set; }
		public string CustomerName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; } = "###-###-####"
		public int OrderId { get; set; }
		public decimal TotalPrice { get; set; }
		public string PaymentType { get; set; }
		public bool OrderStatus { get; set; }
		public decimal TipAmount { get; set; }
		public DateTime DateCreated { get; set; }
		public int CashierId { get; set; }
	}
}

