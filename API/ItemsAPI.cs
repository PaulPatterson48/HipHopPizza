using System;
using HipHopPizzaWings.Models;
using Microsoft.EntityFrameworkCore;

namespace HipHopPizzaWings.API
{
	public class ItemsAPI
	{
		public static void Map(WebApplication app)
		{
			app.MapPost("/newOrder", async (HipHopPizzaWingsDbContext db, OrderItem newOrderItem) =>
			{
				Order order = await db.Orders.FirstOrDefaultAsync(o => o.Id == newOrderItem.OrderId);

				if (order == null)
				{
					return Results.NotFound();
				}
				Item item = await db.Items.FirstOrDefaultAsync(i => i.Id == newOrderItem.ItemId);

				if (item == null)
				{
					return Results.NotFound();
				}

				OrderItem orderItem = new()
				{
					Item = item,
					Order = order
				};

				db.OrderItems.Add(orderItem);
			});

			app.MapDelete("/api/items/{orderId}/delete/{itemId}", (HipHopPizzaWingsDbContext db, int orderId, int itemId) =>
			{
				OrderItem orderItemDeleted = db.OrderItems
											.Where(oitems => oitems.Order.Id == orderId)
											.Where(oitems => oitems.Item.Id == itemId).FirstOrDefault();

				if (orderItemDeleted == null)
				{
					return Results.NotFound();
				}

				db.OrderItems.Remove(orderItemDeleted);
				db.SaveChanges();
				return Results.NoContent();

			});
		}
	}
}

