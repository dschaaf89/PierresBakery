using System;
using System.Collections.Generic;
namespace PierreBakery.Models {

  public class Bread {
    public int totalBreadCost () {
      int totalCost = 0;
      totalCost = (AmtBread * Price);
      if (AmtBread == 3) {
        totalCost = 10;
      }
      
      return totalCost;
    }
    public int Price { get; set; }
    public int AmtBread { get; set; }

    public Bread (int amtBread) {
      AmtBread = amtBread;
      Price = 5;

    }

  }

  public class Pastry {
    
     public int totalPastryCost () {
      int totalCost = 0;
      totalCost = (AmtPastry * Price);
      if (AmtPastry == 3) {
        totalCost --;
      }
      
      return totalCost;
    }
    public int Price { get; set; }
    public int AmtPastry { get; set; }
    public Pastry (int amtPastry) {
      AmtPastry = amtPastry;
      Price = 2;
    }
  }
}