using System;
using HipHopPizzaWings.Models;



namespace HipHopPizzaWings.Data
{
	public class CashierData
	{
		public static List<Cashier> Cahsiers = new List<Cashier>
		{
			new Cashier
			{
				Id = 1,
				Name = "Alice Hyatt",
				email = "aliceHyatt@google.com",
				uid = "AH12345MD"				
			}

			new Cashier
			{
				Id = 2,
				Name = "Florence Jean Casteberry",
				email = "flo@google.com",
				uid = "FJC12345MD"
			}

			new Cashier
			{
				Id = 3,
				Name = "Mel Sharples",
				email = "mel@google.com",
				uid = "MD12345MD"
			}
		}
	}
}

