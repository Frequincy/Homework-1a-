
using System.Globalization;

Console.WriteLine("What is the product name of the item you are purchasing?");

string proD = Console.ReadLine();

Console.WriteLine("How many " + proD + " are you purchasing?");

int prodNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the price for each " + proD + "?");

double ProdPrice = Convert.ToDouble(Console.ReadLine());

double subT = ProdPrice * prodNum;

Console.WriteLine("Your subtotal for your bill is " + subT.ToString("C", CultureInfo.CurrentCulture) + ".");

double TaxPerc = .085;
double SalesT = subT * TaxPerc;

Console.WriteLine("Your subtotal for your bill is " + SalesT.ToString("C", CultureInfo.CurrentCulture) + ".");

double Total = SalesT + subT;

Console.WriteLine("Your subtotal for your bill is " + Total.ToString("C", CultureInfo.CurrentCulture) + ".");
