using System;
using HipHopPizzaWings.Models;

namespace HipHopPizzaWings.Data
{
	public class OrderItemData
	{
		public static List<OrderItem> OrderItems = new List<OrderItem>()
		{
			new OrderItem()
			{
				Id = 1,
				OrderId = 1,
				ItemId = 1
			},

			new OrderItem()
			{
				Id = 2,
				OrderId = 2,
				ItemId = 2
			},

			new OrderItem()
			{
				Id = 3,
				OrderId = 3,
				ItemId = 3
			},
		};
	}
}

