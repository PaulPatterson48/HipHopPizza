using System;
using HipHopPizzaWings.Models;


namespace HipHopPizzaWings.Data
{
	public class PaymentTypeData
	{
		public static List<PaymentType> PaymentTypes = new List<PaymentType>()
		{
			new PaymentType()
			{
				Id = 1,
				Type = "Cash"
			},

			new PaymentType()
			{
				Id = 2,
				Type = "Card"
			},

			new PaymentType()
			{
				Id = 3,
				Type = "Check"
			},

			new PaymentType()
			{
				Id = 4,
				Type = "Cash App"
			}
		};
	}
}

