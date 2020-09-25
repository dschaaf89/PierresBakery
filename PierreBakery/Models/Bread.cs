using System;
using System.Collections.Generic;
namespace PierreBakery.Models {

  public class Bread : Bakery{

   
    public int getTotal () {
      int totalCost = 0;
      totalCost = (AmtBread * Price);
      if (AmtBread == 3) {
        totalCost = 10;
      }
      else if( AmtBread % 3 == 0){
        int subtract = (AmtBread/3)*Price;
        totalCost -= subtract;
      }
      
      return totalCost;
    }
    public int Price { get; set; }
    public int AmtBread { get; set; }
    
    public Bread(){
      Price = 5;
    }

    public Bread (int amtBread) {
      AmtBread = amtBread;
      Price = 5;

    }

  }

  
}