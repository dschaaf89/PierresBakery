using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using PierreBakery;


namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_createsInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetTotal_returnPastryTotalCost_int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(5, newPastry.getTotal());
    }
    [TestMethod]
    public void GetPastryPrice_returnGetPrice_int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.Price);
    }
  }
}