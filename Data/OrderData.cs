using System;
using HipHopPizzaWings.Models;


namespace HipHopPizzaWings.Data
{
	public class OrderData
	{
		public static List<Order> Orders = new List<Order>()
		{
			new Order()
			{
				Id = 1,
				IsPhone = true,
				OrderType = "",
				CustomerName = "John Doe",
				Email = "johnDoe@google.com",
				PhoneNumber = "615-555-1212",
				OrderId = 1,
				PaymentType = "Visa",
				OrderStatus = "closed",
				TipAmount = 4.97M,
				DateCreated = new DateTime(2024, 01, 17),
				CashierId = 1
			},

			new Order()
			{
				Id = 2,
				IsPhone = false,
				OrderType = "Delivery",
				CustomerName = "Alice Smith",
				Email = "alice.smith@example.com",
				PhoneNumber = "615-555-1234",
				OrderId = 2,
				PaymentType = "MasterCard",
				OrderStatus = "delivered",
				TipAmount = 5.00M,
				DateCreated = new DateTime(2024, 02, 05),
				CashierId = 2
			},
			new Order()
			{
				Id = 3,
				IsPhone = true,
				OrderType = "Pickup",
				CustomerName = "Bob Johnson",
				Email = "bob.johnson@example.com",
				PhoneNumber = "615-555-5678",
				OrderId = 3,
				PaymentType = "Cash",
				OrderStatus = "completed",
				TipAmount = 2.00M,
				DateCreated = new DateTime(2024, 03, 12),
				CashierId = 3
			},
			new Order()
			{
				Id = 4,
				IsPhone = true,
				OrderType = "Dine-in",
				CustomerName = "Emily Davis",
				Email = "emily.davis@example.com",
				PhoneNumber = "615-555-9876",
				OrderId = 4,
				PaymentType = "Amex",
				OrderStatus = "pending",
				TipAmount = 7.25M,
				DateCreated = new DateTime(2024, 03, 25),
				CashierId = 1
			},
			new Order()
			{
				Id = 5,
				IsPhone = false,
				OrderType = "Delivery",
				CustomerName = "Michael Wilson",
				Email = "michael.wilson@example.com",
				PhoneNumber = "615-555-4321",
				OrderId = 5,
				PaymentType = "Discover",
				OrderStatus = "processing",
				DateCreated = new DateTime(2024, 04, 02),
				CashierId = 2
			},
			new Order()
			{
				Id = 6,
				IsPhone = true,
				OrderType = "Pickup",
				CustomerName = "Sarah Brown",
				Email = "sarah.brown@example.com",
				PhoneNumber = "615-555-8765",
				OrderId = 6,
				PaymentType = "Cash",
				OrderStatus = "cancelled",
				TipAmount = 0.00M,
				DateCreated = new DateTime(2024, 04, 10),
				CashierId = 3
			}

		};

    }
}

