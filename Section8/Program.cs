using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
	class WoodShop
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the HayWood Store!");

			string enteredType = GetWoodType();
			int userQty = GetDrawerQty();

			double price = GetPrice(userQty, enteredType);
			DisplayResults(price, userQty, enteredType);
		}

		private static string GetWoodType()
		{
			string woodName;
			Console.Write("Enter the type of wood i.e. o, m, p, e ");
			char woodType = Convert.ToChar(Console.ReadLine());
			
			if (woodType == 'p')
			{
				woodName = "Pine"; 
				return woodName;
			}				
			else if (woodType == 'o')
			{
				woodName = "Oak";
				return woodName;
			}				
			else if (woodType == 'e')
			{
				woodName = "Elm";
				return woodName;
			}
			else
			{
				woodName = "Others";
				return woodName;
			}
				
		}

		private static int GetDrawerQty()
		{
			Console.Write("Enter the number of drawer you would like ");
			int number = Convert.ToInt32(Console.ReadLine());

			return number;
		}
		private static double GetPrice(int x, string y)
		{
			int surchage = 30;
			int total = 0;
			if(y == "Pine")
			{
				total = 100 + (x  * surchage);
			}
			else if(y == "Oak")
			{
				total = 140 + (x * surchage);
			}
			 else if (y == "Elm")
			{
				total = 200 + (x * surchage);
			} 
			else
			{
				total = 180 + (x * surchage);
			}
			return total;
		}
		private static void DisplayResults(double finalPrice, int quantity, string type)
		{
			Console.WriteLine("\nYou have ordered a {0} desk with {1} drawer(s)", type, quantity);
			Console.WriteLine("Total price is {0}", finalPrice.ToString("C"));
			Console.ReadLine();
		}
	}
}
