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
      Assert.AreEqual(t.TriangleTyper() == "isoscelese", true);
    }
     [TestMethod]
    public void TriangleTracker_IsIsoscelese_False()
    {
      Triangle t = new Triangle(2,2,2);
      Assert.AreEqual(t.TriangleTyper() == "isoscelese", false);
    }
     [TestMethod]
     public void TriangleTracker_IsIsoscelese_FalseTwo()
    {
      Triangle t = new Triangle(1,2,4);
      Assert.AreEqual(t.TriangleTyper() == "isoscelese", false);
    }
    [TestMethod]
    public void TriangleTracker_IsScalene_True()
    {
      Triangle t = new Triangle(1,2,4);
      Assert.AreEqual(t.TriangleTyper() == "scalene", true);
    }
  }
}