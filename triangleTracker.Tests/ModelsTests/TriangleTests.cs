using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangleTracker;
//using Triangle;

namespace triangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]

    public void TriangleIsEquallateral()
    {
      Triangle testIfEqual = new Triangle();
      Assert.AreEqual(true, testIfEqual.Main(1,1,1));
      //Assert.AreEqual(true, CODE TO TEST);
    }
  }
}