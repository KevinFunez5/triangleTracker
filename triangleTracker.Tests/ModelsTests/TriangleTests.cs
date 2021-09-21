using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;
//using Triangle;

namespace triangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleType_IsEquilateral_Equilateral()
    {
      Assert.AreEqual("equilateral", Triangle.TriangleType(1,1,1));
    }

    [TestMethod]
    public void TriangleType_IsIsosceles_Isosceles()
    {
      Assert.AreEqual("isosceles", Triangle.TriangleType(1,1,2));
    }

    [TestMethod]
    public void TriangleType_IsScalene_Scalene()
    {
      Assert.AreEqual("scalene", Triangle.TriangleType(1,2,3));
    }
  }
}