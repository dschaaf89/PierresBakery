using System;
using System.Collections.Generic;
namespace PierreBakery.Models
{

 
    public class Bread
    {
      public int Price {get;set;}
      public Bread(){
        Price = 5;
      }

    }

    public class Pastry
    {
      public int Price {get;set;}
 public Pastry(){
        Price = 2;
      }
    }
}