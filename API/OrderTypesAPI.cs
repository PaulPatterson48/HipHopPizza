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

		}
	}
}

