using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using PierreBakery;
namespace PierreBakery.Tests
{
  [TestClass]
  public class DrinkTests
  {
    [TestMethod]
    public void DrinkConstructor_createsInstanceOfDrink_Drink()
    {
      Drinks newDrink = new Drinks();
      Assert.AreEqual(typeof(Drinks), newDrink.GetType());
    }
    [TestMethod]
    public void GetTotal_returnDrinkTotalCost_int()
    {
      Drinks newDrink = new Drinks(3);
      Assert.AreEqual(9, newDrink.getTotal());
    }
    [TestMethod]
    public void GetDrinksPrice_returnGetPrice_int()
    {
      Drinks newDrink = new Drinks();
      Assert.AreEqual(3, newDrink.Price);
    }
  }
}