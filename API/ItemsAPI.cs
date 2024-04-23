using System;
using HipHopPizzaWings.Models;
using Microsoft.EntityFrameworkCore;

namespace HipHopPizzaWings.API
{
	public class ItemsAPI
	{
		public static void Map(WebApplication app)
		{
			app.MapGet("/api/items", (HipHopPizzaWingsDbContext db) =>
			{
				return db.Items.ToList();
			});

			app.MapGet("/api/items/{id}", (HipHopPizzaWingsDbContext db, int id) =>
			{
				var item = db.Items.FirstOrDefault(i => i.Id == id);
				if (item == null)
				{
					return Results.NotFound("No Item found");
				}
				return Results.Ok(item); 
			});
		}
			
	}
}

