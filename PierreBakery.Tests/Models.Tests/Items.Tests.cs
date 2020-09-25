using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

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
    public void PastryConstructor_createsInstanceOfPastry_Bread () {
      Pastry newPastry = new Pastry ();
      Assert.AreEqual (typeof (Pastry), newPastry.GetType ());
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
      Assert.AreEqual(5,newPastry.Price);
    }
  }
}