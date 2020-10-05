using System.Reflection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using PierreBakery;

namespace PierreBakery.Tests

{
  [TestClass]
  public class BreadTests {

    [TestMethod]
    public void BreadConstructor_createsInstanceOfBread_Bread () {
      Bread newBread = new Bread ();
      Assert.AreEqual (typeof (Bread), newBread.GetType ());
    }
    [TestMethod]
    public void GetBreadPrice_returnGetPrice_int () 
    {
      Bread newBread = new Bread ();
      Assert.AreEqual(5,newBread.Price);
    }
    [TestMethod]
    public void GetTotal_returnBreadTotalCost_int()
    {
      Bread newBread  = new Bread(4);
      Assert.AreEqual(20,newBread.getTotal());
    }
  }
}