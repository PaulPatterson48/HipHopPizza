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

			app.MapPost("/api/checkCashier/{uid}", (HipHopPizzaWingsDbContext db, string uid, Cashier newCashiers) =>
			{
				Cashier checkCashier = db.Cashiers.FirstOrDefault(cashier => cashier.uid == uid);

				if (checkCashier != null)
				{
					return Results.Ok(checkCashier);
				}

				Cashier newCashier = new Cashier();
				newCashier.uid = newCashier.uid;
				newCashier.Name = newCashier.Name;
				newCashier.email = newCashier.email;

				db.Cashiers.Add(newCashier);
				db.SaveChanges();

				return Results.Ok(newCashier);
			
			}); 
		}

		
	}
}

