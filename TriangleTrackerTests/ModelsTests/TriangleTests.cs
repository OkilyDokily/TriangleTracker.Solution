using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTrackerTests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      Triangle t = new Triangle(2,2,2);
      Assert.AreEqual(t.TriangleTyper(), "equilateral");
    }


  }
}