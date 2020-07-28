using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTrackerTests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleTyper_IsEquilateral_True()
    {
      Triangle t = new Triangle(2,2,2);
      Assert.AreEqual(t.TriangleTyper() == "equilateral", true);
    }
    [TestMethod]
    public void TriangleTyper_IsEquilateral_False()
    {
      Triangle t = new Triangle(2,2,3);
      Assert.AreEqual(t.TriangleTyper() == "equilateral", false);
    }
    [TestMethod]
    public void TriangleTracker_IsIsoscelese_True()
    {
      Triangle t = new Triangle(2,2,3);
      Assert.AreEqual(t.TriangleTyper() == "isosceles", true);
    }
     [TestMethod]
    public void TriangleTracker_IsIsoscelese_False()
    {
      Triangle t = new Triangle(2,2,2);
      Assert.AreEqual(t.TriangleTyper() == "isosceles", false);
    }
     [TestMethod]
     public void TriangleTracker_IsIsoscelese_FalseTwo()
    {
      Triangle t = new Triangle(1,2,4);
      Assert.AreEqual(t.TriangleTyper() == "isosceles", false);
    }
    [TestMethod]
    public void TriangleTracker_IsScalene_True()
    {
      Triangle t = new Triangle(1,2,3);
      Assert.AreEqual(t.TriangleTyper() == "scalene", true);
    }

    [TestMethod]
    public void TriangleTracker_IsScalene_False()
    {
      Triangle t = new Triangle(1,2,2);
      Assert.AreEqual(t.TriangleTyper() == "scalene", false);
    }

      [TestMethod]
    public void TriangleTracker_IsScalene_FalseTwo()
    {
      Triangle t = new Triangle(2,2,2);
      Assert.AreEqual(t.TriangleTyper() == "scalene", false);
    }

    [TestMethod]
    public void TriangleTracker_IsNotATriangle_True()
    {
      Triangle t = new Triangle(10,2,2);
      Assert.AreEqual(t.TriangleTyper() == "is not a triangle", true);
    }

     [TestMethod]
    public void TriangleTracker_IsNotATriangle_False()
    {
      Triangle t = new Triangle(3,2,2);
      Assert.AreEqual(t.TriangleTyper() == "is not a triangle", false);
    }
  }
}