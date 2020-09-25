using System;
using System.Collections.Generic;
using PierreBakery.Models;
namespace PierreBakery {
  public class Program {
    static Dictionary<int, string> breadTypes = new Dictionary<int, string> () { { 0, "Ciabatta" }, { 1, "French" }, { 2, "Sourdough" }, { 3, "Wheat" }, { 4, "Rye" }
    };

    static Dictionary<int, string> pastryTypes = new Dictionary<int, string> () { { 0, "Croissants" }, { 1, "Apple Strudel" }, { 2, "Cannoli" }, { 3, "Bear Claw" }, { 4, "Cherry Turnover" }
    };

    public static void Main () {
      Console.WriteLine ("Welcome to Pierres Bakery. Home to the best Breads and Pastry's in the NorthWest");
      Console.WriteLine ("We have two specials going on today. Our first Special is on Bread if you buy 2 bread you get the 3rd bread free. this is only on the first three loafs though");
      Console.WriteLine ("Our second Special is for our pastries. we have a buy 1 pastry for $2 and 3 for $5 dollars");
      Console.WriteLine ("What would you like to order today. write bread,pastry, or both. any other word will close the order process");

      string answer = Console.ReadLine ();
      if (answer.ToLower () == "bread") {

      
        // for(int i = 0; i <= breadTypes.Count; i ++ ){
        //   Console.WriteLine(Key[i],Value[i]);
        // } tried writing dictionary out and it wouldn't work need help here"


        Console.WriteLine("what type of bread do you want to buy?");
        Console.WriteLine("Ciabatta");
        Console.WriteLine("French");
        Console.WriteLine("Sourdough");
        Console.WriteLine("Rye");
        string breadType = Console.ReadLine();

        Console.WriteLine ("How many loafs of " +breadType+" would you like to buy");
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);
        int TotalCost = orderBread.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread +" "+ breadType+" bread loafs" );




      } else if (answer.ToLower () == "pastry") {
        Console.WriteLine ("How many pastries would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);
        int TotalCost = orderPastry.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost);
      } else if (answer.ToLower () == "both") {
        Console.WriteLine("what type of bread do you want to buy?");
        Console.WriteLine("Ciabatta");
        Console.WriteLine("French");
        Console.WriteLine("Sourdough");
        Console.WriteLine("Rye");
        string breadType = Console.ReadLine();

        Console.WriteLine ("How many loafs of " +breadType+" would you like to buy");
        Console.WriteLine ("How many bread loafs would you like to buy");
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);
        Console.WriteLine ("How many pastries would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);

        int TotalCost = orderBread.getTotal () + orderPastry.getTotal ();

        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread + " bread and " + amtPastry + " pastries");

      } else {
        Console.WriteLine ("Thanks for coming to Pierre's Bakery");
      }
    }
  }
}