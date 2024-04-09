using System;
using System.Collections.Generic;
using HipHopPizzaWings.Models;


namespace HipHopPizzaWings.Data
{
	public class ItemData
	{
        public static List<Item> Items = new List<Item>()
        {
            new Item()
            {
                Id = 1,
                OrderId = 1,
                ItemName = "Cheese Pizza",
                ItemPrice = 10.00M
            },

            new Item()
            {
                Id = 2,
                OrderId = 2,
                ItemName = "Plain Wings",
                ItemPrice = 6.00M
            },

            new Item()
            {
                Id = 3,
                OrderId = 3,
                ItemName = "Pepperoni Pizza",
                ItemPrice = 12.00M
            },

            new Item()
            {
                Id = 4,
                OrderId = 4,
                ItemName = "BBQ Wings",
                ItemPrice = 8.50M
            },
            new Item()
            {
                Id = 5,
                OrderId = 5,
                ItemName = "Garlic Knots",
                ItemPrice = 5.25M
            },
            new Item()
            {
                Id = 6,
                OrderId = 6,
                ItemName = "Hawaiian Pizza",
                ItemPrice = 14.50M
            },
            new Item()
            {
                Id = 7,
                OrderId = 7,
                ItemName = "Buffalo Wings",
                ItemPrice = 7.00M
            },
            new Item()
            {
                Id = 8,
                OrderId = 8,
                ItemName = "Caesar Salad",
                ItemPrice = 9.75M
            }
        };

    }

 }

