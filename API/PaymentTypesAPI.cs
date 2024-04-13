using System;
using HipHopPizzaWings.Models;
using Microsoft.EntityFrameworkCore;

namespace HipHopPizzaWings.API
{
	public class PaymentTypesAPI
	{
		public static void Map(WebApplication app)
		{
			app.MapGet("/api/paymentTypes", (HipHopPizzaWingsDbContext db) =>
			{
				var paymentTypes = db.PaymentTypes.ToList();
				return Results.Ok(paymentTypes);

			});
		}
	}
}

