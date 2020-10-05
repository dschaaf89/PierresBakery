using System;
using System.Collections.Generic;
namespace PierreBakery.Models
{
  public class Pastry : Bakery
  {

    static public Dictionary<int, string> pastryTypes = new Dictionary<int, string>() { { 0, "Croissants" }, { 1, "Apple Strudel" }, { 2, "Cannoli" }, { 3, "Bear Claw" }, { 4, "Cherry Turnover" }
    };
    public int Price { get; set; }
    public int AmtPastry { get; set; }
    public Pastry()
    {
      { Price = 2; }
    }
    public Pastry(int amtPastry)
    {
      AmtPastry = amtPastry;
      Price = 2;
    }
    public int getTotal()
    {
      int totalCost = 0;
      totalCost = (AmtPastry * Price);
      if (AmtPastry == 3)
      {
        totalCost = 5;
      }
      else if (AmtPastry % 3 == 0)
      {
        totalCost = (AmtPastry / 3) * 5;
      }
      return totalCost;
    }
  }
}