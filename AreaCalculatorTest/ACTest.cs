using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Calc_Neal;

namespace AreaCalculatorTest
{
    [TestClass]
    public class ACTest
    {
        [TestMethod]
        public void SquareAreaIntSuccess()
        {
            Assert.AreEqual(1, AreaCalculator.GetSquareArea(1));
            Assert.AreEqual(4, AreaCalculator.GetSquareArea(2));
            Assert.AreEqual(9, AreaCalculator.GetSquareArea(3));
            Assert.AreEqual(0, AreaCalculator.GetSquareArea(0));
            Assert.AreEqual(25, AreaCalculator.GetSquareArea(-5));
        }
        [TestMethod]
        public void SquareAreaStringSuccess()
        {
            Assert.AreEqual(1, AreaCalculator.GetSquareArea("one"));
            Assert.AreEqual(4, AreaCalculator.GetSquareArea("twO"));
            Assert.AreEqual(9, AreaCalculator.GetSquareArea("thRee"));
            Assert.AreEqual(16, AreaCalculator.GetSquareArea("four"));
            Assert.AreEqual(25, AreaCalculator.GetSquareArea("five"));
            Assert.AreEqual(36, AreaCalculator.GetSquareArea("Six"));
            Assert.AreEqual(49, AreaCalculator.GetSquareArea("Seven"));
            Assert.AreEqual(64, AreaCalculator.GetSquareArea("eight"));
            Assert.AreEqual(81, AreaCalculator.GetSquareArea("NINE"));
            Assert.AreEqual(100, AreaCalculator.GetSquareArea("ten"));
        }
        [TestMethod]
        public void SquareAreaStringFailure()
        {
            Assert.AreEqual(null, AreaCalculator.GetSquareArea("jordan"));
        }
        [TestMethod]
        public void RectangleAreaSuccess()
        {
            Assert.AreEqual(2, AreaCalculator.GetRectangleArea(1, 2));
            Assert.AreEqual(6, AreaCalculator.GetRectangleArea(2, 3));
            Assert.AreEqual(20, AreaCalculator.GetRectangleArea(4, 5));
            Assert.AreEqual(-90, AreaCalculator.GetRectangleArea(10, -9));
            Assert.AreEqual(25, AreaCalculator.GetRectangleArea(-5, -5));
        }
        [TestMethod]
        public void TriangleAreaSuccess()
        {
            Assert.AreEqual(12.5, AreaCalculator.GetTriangleArea(5, 5));
            Assert.AreEqual(25, AreaCalculator.GetTriangleArea(10, 5));
            Assert.AreEqual(16, AreaCalculator.GetTriangleArea(4, 8));
            Assert.AreEqual(13.5, AreaCalculator.GetTriangleArea(3, 9));
            Assert.AreEqual(1000, AreaCalculator.GetTriangleArea(100, 20));

        }
        [TestMethod]
        public void ParallelogramAreaSuccess()
        {
            Assert.AreEqual(25, AreaCalculator.GetParallelogramArea(5, 5));
        }
        [TestMethod]
        public void CircleRadiusSuccess()
        {
            Assert.AreEqual(2.5, AreaCalculator.GetCircleRadius(5));
        }
        [TestMethod]
        public void CircleDiameterSuccess()
        {
            Assert.AreEqual(10, AreaCalculator.GetCircleDiameter(5));
        }
        [TestMethod]
        public void SquareIntSuccess()
        {
            Assert.AreEqual(400, AreaCalculator.MultiplyInts(20));
        }
        [TestMethod]
        public void MultiplyIntsSuccess()
        {
            Assert.AreEqual(500, AreaCalculator.MultiplyInts(5, 100));
        }
        [TestMethod]
        public void DivideByTwoAndRoundSuccess()
        {
            Assert.AreEqual(8.5, AreaCalculator.DivideByTwoAndRound(17));
        }
    }
}