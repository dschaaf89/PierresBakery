using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using PierreBakery;

namespace PierreBakery.Tests

{
  [TestClass]
  public class ItemTests {

    [TestMethod]
    public void BreadConstructor_createsInstanceOfBread_Bread () {
      Bread newBread = new Bread ();
      Assert.AreEqual (typeof (Bread), newBread.GetType ());
    }

    [TestMethod]
    public void PastryConstructor_createsInstanceOfPastry_Pastry () {
      Pastry newPastry = new Pastry ();
      Assert.AreEqual (typeof (Pastry), newPastry.GetType ());
    }
     [TestMethod]
    public void DrinkConstructor_createsInstanceOfDrink_Drink () {
      Drinks newDrink = new Drinks ();
      Assert.AreEqual (typeof (Drinks), newDrink.GetType ());
    }

    [TestMethod]
    public void GetBreadPrice_returnGetPrice_int () 
    {
      Bread newBread = new Bread ();
      Assert.AreEqual(5,newBread.Price);
    }
    [TestMethod]
    public void GetPastryPrice_returnGetPrice_int () 
    {
      Pastry newPastry = new Pastry ();
      Assert.AreEqual(2,newPastry.Price);
    }
    [TestMethod]
    public void GetDrinksPrice_returnGetPrice_int () 
    {
      Drinks newDrink = new Drinks ();
      Assert.AreEqual(3,newDrink.Price);
    }
    [TestMethod]
    public void GetTotal_returnBreadTotalCost_int()
    {
      Bread newBread  = new Bread(4);
      Assert.AreEqual(20,newBread.getTotal());
    }
    [TestMethod]
    public void GetTotal_returnPastryTotalCost_int()
    {
      Pastry newPastry  = new Pastry(3);
      Assert.AreEqual(5,newPastry.getTotal());
    }
     [TestMethod]
    public void GetTotal_returnDrinkTotalCost_int()
    {
       Drinks newDrink = new Drinks (3);
      Assert.AreEqual(9,newDrink.getTotal());
    }
   
  }
}