using System;
using System.Collections.Generic;
using PierreBakery.Models;
namespace PierreBakery {
  public class Program {

    public static void Main () {
      Console.WriteLine ("Welcome to Pierres Bakery. Home to the best Breads and Pastry's in the NorthWest");
      Console.WriteLine ("We have two specials going on today. Our first Special is on Bread if you buy 2 bread you get the 3rd bread free. this is only on the first three loafs though");
      Console.WriteLine ("Our second Special is for our pastries. we have a buy 1 pastry for $2 and 3 for $5 dollars");
      Console.WriteLine ("What would you like to order today. write drink,bread,pastry, or all. any other word will close the order process");

      string answer = Console.ReadLine ();
      if(answer.ToLower() == "drink")
      {
        Console.WriteLine ("what type of Drinks do you want to buy? choose the number");
        for (int i = 0; i < Drinks.drinkTypes.Count; i++) {
          string num = i.ToString ();
          Console.WriteLine (num + " , " + Drinks.drinkTypes[i]);
        }
        int number = int.Parse (Console.ReadLine ());

      Console.WriteLine ("How many loafs of " + Drinks.drinkTypes[number] + " would you like to buy");
        int amtDrink = int.Parse (Console.ReadLine ());
        Drinks orderDrink = new Drinks (amtDrink);
        int TotalCost = orderDrink.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtDrink + " " + Drinks.drinkTypes[number] + " drinks");





      }
      else if (answer.ToLower () == "bread") {
        Console.WriteLine ("what type of bread do you want to buy? choose the number");
        for (int i = 0; i < Bread.breadTypes.Count; i++) {
          string num = i.ToString ();
          Console.WriteLine (num + " , " + Bread.breadTypes[i]);
        }
        int number = int.Parse (Console.ReadLine ());

        Console.WriteLine ("How many loafs of " + Bread.breadTypes[number] + " would you like to buy");
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);
        int TotalCost = orderBread.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread + " " + Bread.breadTypes[number] + " bread loafs");

      } else if (answer.ToLower () == "pastry") {

        Console.WriteLine ("what type of pastry do you want to buy?choose the number");
        for (int i = 0; i < Pastry.pastryTypes.Count; i++) {
          string num = i.ToString ();
          Console.WriteLine (num + " , " + Pastry.pastryTypes[i]);
        }
        int number = int.Parse (Console.ReadLine ());

        Console.WriteLine ("How many " + Pastry.pastryTypes[number] + " would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);
        int TotalCost = orderPastry.getTotal ();
        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtPastry + " " + Pastry.pastryTypes[number] + " pastries");


      } else if (answer.ToLower () == "all") {

 Console.WriteLine ("what type of Drinks do you want to buy? choose the number");
        for (int i = 0; i < Drinks.drinkTypes.Count; i++) {
          string num = i.ToString ();
          Console.WriteLine (num + " , " + Drinks.drinkTypes[i]);
        }
        int number3 = int.Parse (Console.ReadLine ());

      Console.WriteLine ("How many of cups" + Drinks.drinkTypes[number3] + " would you like to buy");
        int amtDrink = int.Parse (Console.ReadLine ());
        Drinks orderDrink = new Drinks (amtDrink);



        Console.WriteLine ("what type of bread do you want to buy? choose the number");
        for (int i = 0; i < Bread.breadTypes.Count; i++) {
          string num1 = i.ToString ();
          Console.WriteLine (num1 + " , " + Bread.breadTypes[i]);
        }
        int number1 = int.Parse (Console.ReadLine ());
        Console.WriteLine ("How many loafs of " + Bread.breadTypes[number1] + " would you like to buy");
        
        int amtBread = int.Parse (Console.ReadLine ());
        Bread orderBread = new Bread (amtBread);


        Console.WriteLine ("what type of pastry do you want to buy?");
        for (int i = 0; i < Pastry.pastryTypes.Count; i++) {
          string num2 = i.ToString ();
          Console.WriteLine (num2 + " , " + Pastry.pastryTypes[i]);
        }
        int number2 = int.Parse (Console.ReadLine ());

        Console.WriteLine ("How many "+Pastry.pastryTypes[number2] +" would you like to buy");
        int amtPastry = int.Parse (Console.ReadLine ());
        Pastry orderPastry = new Pastry (amtPastry);

        int TotalCost = orderBread.getTotal () + orderPastry.getTotal () + orderDrink.getTotal();


        Console.WriteLine ("Your order Totals to $" + TotalCost + " for your order of " + amtBread + " " + Bread.breadTypes[number1] + " bread loafs, " + amtPastry + " " + Pastry.pastryTypes[number2] + " pastries and " + amtDrink+" "+ Drinks.drinkTypes[number3] + " drinks");

      } else {
        Console.WriteLine ("Thanks for coming to Pierre's Bakery");
      }
    }
  }
}