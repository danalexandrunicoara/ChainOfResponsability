using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class Client
	{
		public static void CallingHandler(IHandler handler)
		{
			var foodItems = new List<string> { "Banana", "MeatBall" };
			foreach (var food in foodItems)
			{
				var result = handler.Handle(food);
				if (result != null)
					Console.WriteLine(result);
				else Console.WriteLine("Food remained untouched");
			}
		}
	}
}
