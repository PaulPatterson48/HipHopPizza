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
			app.MapPost("/api/checkCashier/{uid}", (HipHopPizzaWingsDbContext db, string uid, Cashier newCashier) =>
			{
				Cashier checkCashier = db.Cashiers.FirstOrDefault(cashier => cashier.uid == uid);

				if (checkCashier != null)
				{
					return Results.Ok(checkCashier);
				}

				Cashier newCashiers = new Cashier();
				newCashiers.uid = newCashier.uid;
				newCashiers.Name = newCashier.Name;
				newCashiers.email = newCashier.email;

				db.Cashiers.Add(newCashier);
				db.SaveChanges();

				return Results.Ok(newCashier);
			
			}); 
		}

		
	}
}

