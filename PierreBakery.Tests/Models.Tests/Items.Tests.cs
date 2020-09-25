using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests

{
    [TestClass]
    public class ItemTests
    {
      
      [TestMethod]
      public void BreadConstructor_createsInstanceOfBread_Bread(){
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread),newBread.GetType());
      }
    }
}