using System;
using HipHopPizzaWings.Models;
using Microsoft.EntityFrameworkCore;

namespace HipHopPizzaWings.API
{
	public class OrderTypesAPI
	{
		public static void Map(WebApplication app)
		{
			app.MapGet("/api/OrderTypes", (HipHopPizzaWingsDbContext db) =>
			{
				var orderTypes = db.OrderTypes.ToList();
				return Results.Ok(orderTypes);

			});

			app.MapPost("/api/orderItems", (HipHopPizzaWingsDbContext db, OrderItem createOrderItem) =>
			{
				db.OrderItems.Add(createOrderItem);
				db.SaveChanges();
				return Results.Created($"/api.orderItems/{createOrderItem.Id}", createOrderItem);
			});

			app.MapDelete("/api/orderItems/{id}", (HipHopPizzaWingsDbContext db, int id) =>
			{
				OrderItem deletedOrderItems = db.OrderItems.SingleOrDefault(deletedOrderItems => deletedOrderItems.Id == id);
				if (deletedOrderItems == null)
				{
					return Results.NotFound($"No Items to Delete");
				}
				db.OrderItems.Remove(deletedOrderItems);
				db.SaveChanges();
				return Results.NoContent();
			});

			app.MapPut("/api/orderItems/{id}", (HipHopPizzaWingsDbContext db, int id, OrderItem orderItem) =>
			{
				OrderItem updatedOrderItems = db.OrderItems.SingleOrDefault(o => o.Id == id);
				if (updatedOrderItems == null)
				{
					return Results.NotFound();
				}
				updatedOrderItems.Quantity = orderItem.Quantity;
				db.SaveChanges();
				return Results.NoContent();
			});

			app.MapGet("/api/orderItem/{id}", (HipHopPizzaWingsDbContext db, int id) =>
			{
				var singleOrder = db.OrderItems.FirstOrDefault(s => s.Id == id);
				if (singleOrder == null)
				{
					return Results.NotFound("No order found");
				}
				return Results.Ok(singleOrder);
			});

			app.MapGet("/api/getProducts/bySeller", (HipHopPizzaWingsDbContext db, int OrderId) =>
			{
				var findOrders = db.OrderItems.Where(o => o.OrderId == OrderId).ToList();
				if (!findOrders.Any())
				{
					return Results.NotFound("No items on this order");
				}
				return Results.Ok(findOrders);
			});
		}
	}
}

