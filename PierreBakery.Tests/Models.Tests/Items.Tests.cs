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
      Bread newBread = new Bread (1);
      Assert.AreEqual (typeof (Bread), newBread.GetType ());
    }

    [TestMethod]
    public void PastryConstructor_createsInstanceOfPastry_Bread () {
      Pastry newPastry = new Pastry (1);
      Assert.AreEqual (typeof (Pastry), newPastry.GetType ());
    }

    [TestMethod]
    public void GetBreadPrice_returnGetPrice_int () 
    {
      Bread newBread = new Bread (1);
      Assert.AreEqual(5,newBread.Price);
    }
    [TestMethod]
    public void GetPastryPrice_returnGetPrice_int () 
    {
      Pastry newPastry = new Pastry (1);
      Assert.AreEqual(2,newPastry.Price);
    }
    [TestMethod]
    public void GetBreadTotal_returnBreadTotalCost_int()
    {
      Bread newBread  = new Bread(4);
      Assert.AreEqual(20,newBread.totalBreadCost());
    }
    [TestMethod]
    public void GetPastryTotal_returnPastryTotalCost_int()
    {
      Pastry newPastry  = new Pastry(3);
      Assert.AreEqual(5,newPastry.totalPastryCost());
    }
   
  }
}