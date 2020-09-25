using System;
using PierreBakery.Models;
namespace PierreBakery
{
    public class Program
  {
   
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery. Home to the best Breads and Pastry's in the NorthWest");
      Console.WriteLine("We have two specials going on today. Our first Special is on Bread if you buy 2 bread you get the 3rd bread free. this is only on the first three loafs though");
      Console.WriteLine("Our second Special is for our pastries. we have a buy 1 pastry for $2 and 3 for $5 dollars");
      Console.WriteLine("What would you like to order today. write bread,pastry, or both. any other word will close the order process");

      string answer = Console.ReadLine();
      if(answer.ToLower() == "bread"){
        Console.WriteLine("How many bread loafs would you like to buy");
        int amtBread = int.Parse(Console.ReadLine());
        Bread orderBread = new Bread (amtBread);
        int TotalCost = orderBread.getTotal();
        Console.WriteLine("Your order Totals to $"+TotalCost);
      }
      else if(answer.ToLower() == "pastry"){
        Console.WriteLine("How many pastries would you like to buy");
        int amtPastry = int.Parse(Console.ReadLine());
        Pastry orderPastry = new Pastry (amtPastry);
        int TotalCost = orderPastry.getTotal();
        Console.WriteLine("Your order Totals to $"+TotalCost);        
      }
     

      else if(answer.ToLower()== "both")
      {
        Console.WriteLine("How many bread loafs would you like to buy");
        int amtBread = int.Parse(Console.ReadLine());
        Bread orderBread = new Bread (amtBread);
        Console.WriteLine("How many pastries would you like to buy");
        int amtPastry = int.Parse(Console.ReadLine());
        Pastry orderPastry = new Pastry (amtPastry);

        int TotalCost = orderBread.getTotal() + orderPastry.getTotal();

        Console.WriteLine("Your order Totals to $"+TotalCost);
        
      }
      else
      {
        Console.WriteLine("Thanks for coming to Pierre's Bakery");
      }
    }
  }
}