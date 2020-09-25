
namespace PierreBakery.Models
{
    public class Pastry : Bakery{
    
     public int getTotal () {
      int totalCost = 0;
      totalCost = (AmtPastry * Price);
      if (AmtPastry == 3) {
        totalCost= 5;
      }else if( AmtPastry % 3 == 0){
        totalCost = (AmtPastry/3)*5;
       
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