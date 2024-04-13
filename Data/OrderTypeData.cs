using System;
using HipHopPizzaWings.Models;

namespace HipHopPizzaWings.Data
{
	public class OrderTypeData
	{
		public static List<OrderType> OrderTypes = new List<OrderType>()
		{
			new OrderType()
			{
				Id = 1,
				Type = "In Person"
			},

			new OrderType()
			{
				Id = 2,
				Type = "Phone"
			},

			new OrderType()
			{
				Id = 3,
				Type = "Web"
			}
		};
	}
}

