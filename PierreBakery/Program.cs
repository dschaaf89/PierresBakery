using System;
using System.Collections.Generic;
using PierreBakery.Models;
namespace PierreBakery {
  public class Program {
   
    public static void Main () {
      Console.WriteLine ("Welcome to Pierres Bakery. Home to the best Breads and Pastry's in the NorthWest");
      Console.WriteLine ("We have two specials going on today. Our first Special is on Bread if you buy 2 bread you get the 3rd bread free. this is only on the first three loafs though");
      Console.WriteLine ("Our second Special is for our pastries. we have a buy 1 pastry for $2 and 3 for $5 dollars");
      Console.WriteLine ("What would you like to order today. write bread,pastry, or both. any other word will close the order process");

      string answer = Console.ReadLine ();
      if (answer.ToLower () == "bread") { 
        Console.WriteLine("what type of bread do you want to buy? choose the number");
         for(int i = 0; i < Bread.breadTypes.Count; i ++ ){
           string num = i.ToString();
           Console.WriteLine (num +" , "+ Bread.breadTypes[i]);
         }
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine ("How many loafs of " + Bread.breadTypes[number] +" would you like to buy");
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);
        int TotalCost = orderBread.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread +" "+ Bread.breadTypes[number]+" bread loafs" );




      } else if (answer.ToLower () == "pastry") {

        Console.WriteLine("what type of pastry do you want to buy?");
        for(int i = 0; i < Bread.breadTypes.Count; i ++ ){
           Console.WriteLine(Pastry.pastryTypes[i]);
         }
        string pastryType = Console.ReadLine();

        Console.WriteLine ("How many pastries would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);
        int TotalCost = orderPastry.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtPastry +" "+ pastryType+" pastries" );
      } else if (answer.ToLower () == "both") {
        Console.WriteLine("what type of bread do you want to buy?");
        for(int i = 0; i < Bread.breadTypes.Count; i ++ ){
           Console.WriteLine(Bread.breadTypes[i]);
         }
        string breadType = Console.ReadLine();

        Console.WriteLine ("How many loafs of " +breadType+" would you like to buy");
        Console.WriteLine ("How many bread loafs would you like to buy");
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);
        Console.WriteLine("what type of pastry do you want to buy?");
         for(int i = 0; i < Bread.breadTypes.Count; i ++ ){
           Console.WriteLine(Pastry.pastryTypes[i]);
         }
        string pastryType = Console.ReadLine();
        Console.WriteLine ("How many pastries would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);

        int TotalCost = orderBread.getTotal () + orderPastry.getTotal ();

        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread +" "+ breadType+" bread loafs  and " + amtPastry +" "+ pastryType+" pastries");

      } else {
        Console.WriteLine ("Thanks for coming to Pierre's Bakery");
      }
    }
  }
}