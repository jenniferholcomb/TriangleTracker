using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsEquilateral_AllInputsEqual_True()
    {
      Triangle testTriangleTracker = new Triangle(5, 5, 5);
      Assert.AreEqual(true, testTriangleTracker.IsEquilateral());
    }

    [TestMethod]
    public void IsIsoceles_TwoSidesEqual_True()
    {
      Triangle testTriangleTracker = new Triangle(10, 10, 5);
      Assert.AreEqual(true, testTriangleTracker.IsIsoceles());
    }

    [TestMethod]
    public void IsScalene_NoSidesEqual_True()
    {
      Triangle testTriangleTracker = new Triangle(3, 5, 7);
      Assert.AreEqual(true, testTriangleTracker.IsScalene());
    }

    [TestMethod]
    public void TypeOfTriangle_IsATriangle_String()
    {
      Triangle testTriangleTracker = new Triangle(4, 4, 12);
      Assert.AreEqual("Not a triangle", testTriangleTracker.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsAEquilateral_String()
    {
      Triangle testTriangleTracker = new Triangle(4, 4, 4);
      Assert.AreEqual("This is an equilateral triangle", testTriangleTracker.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsAIsoceles_String()
    {
      Triangle testTriangleTracker = new Triangle(4, 4, 5);
      Assert.AreEqual("This is an isoceles triangle", testTriangleTracker.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsAScalene_String()
    {
      Triangle testTriangleTracker = new Triangle(4, 6, 5);
      Assert.AreEqual("This is a scalene triangle", testTriangleTracker.TypeOfTriangle()); 
    }
  }
}