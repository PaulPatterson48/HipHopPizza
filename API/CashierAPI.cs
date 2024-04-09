using System;
using HipHopPizzaWings.Models;
using Microsoft.EntityFrameworkCore;

namespace HipHopPizzaWings.API
{
	public static class CashierAPI
	{
		public static void Map(WebApplication app)
		{
			//Create Cashier
			app.MapPost("/api/createCashier", (HipHopPizzaWingsDbContext db, Cashier newCashier) =>
			{
				db.Cashiers.Add(newCashier);
				db.SaveChanges();
				return Results.Created($"/api/createCashier/{newCashier.Id}", newCashier);
			});
		}
	}
}

