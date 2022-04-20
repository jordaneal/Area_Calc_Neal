using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Calc_Neal;

namespace AreaCalculatorTest
{
    [TestClass]
    public class ACTest
    {
        AreaCalculator ac = new AreaCalculator();

        [TestMethod]
        public void SquareAreaIntSuccess()
        {
            Assert.AreEqual(1, ac.GetSquareArea(1));
            Assert.AreEqual(4, ac.GetSquareArea(2));
            Assert.AreEqual(9, ac.GetSquareArea(3));
            Assert.AreEqual(0, ac.GetSquareArea(0));
            Assert.AreEqual(25, ac.GetSquareArea(-5));
        }
        [TestMethod]
        public void SquareAreaStringSuccess()
        {
            Assert.AreEqual(1, ac.GetSquareArea("one"));
            Assert.AreEqual(4, ac.GetSquareArea("two"));
            Assert.AreEqual(9, ac.GetSquareArea("three"));
            Assert.AreEqual(16, ac.GetSquareArea("four"));
            Assert.AreEqual(25, ac.GetSquareArea("five"));
            Assert.AreEqual(36, ac.GetSquareArea("six"));
            Assert.AreEqual(49, ac.GetSquareArea("seven"));
            Assert.AreEqual(64, ac.GetSquareArea("eight"));
            Assert.AreEqual(81, ac.GetSquareArea("nine"));
            Assert.AreEqual(100, ac.GetSquareArea("ten"));
        }
        [TestMethod]
        public void SquareAreaStringFailure()
        {
            Assert.AreEqual(-1, ac.GetSquareArea("jordan"));
        }
        [TestMethod]
        public void RectangleAreaSuccess()
        {
            Assert.AreEqual(2, ac.GetRectangleArea(1, 2));
            Assert.AreEqual(6, ac.GetRectangleArea(2, 3));
            Assert.AreEqual(20, ac.GetRectangleArea(4, 5));
            Assert.AreEqual(-90, ac.GetRectangleArea(10, -9));
            Assert.AreEqual(25, ac.GetRectangleArea(-5, -5));
        }
        [TestMethod]
        public void TriangleAreaSuccess()
        {
            Assert.AreEqual(12.5, ac.GetTriangleArea(5, 5));
            Assert.AreEqual(25, ac.GetTriangleArea(10, 5));
            Assert.AreEqual(16, ac.GetTriangleArea(4, 8));
            Assert.AreEqual(13.5, ac.GetTriangleArea(3, 9));
            Assert.AreEqual(1000, ac.GetTriangleArea(100, 20));

        }
        [TestMethod]
        public void ParallelogramAreaSuccess()
        {
            Assert.AreEqual(25, ac.GetParallelogramArea(5, 5));
        }
        [TestMethod]
        public void CircleRadiusSuccess()
        {
            Assert.AreEqual(2.5, ac.GetCircleRadius(5));
        }
        [TestMethod]
        public void CircleDiameterSuccess()
        {
            Assert.AreEqual(10, ac.GetCircleDiameter(5));
        }
        [TestMethod]
        public void SquareIntSuccess()
        {
            Assert.AreEqual(400, ac.MultiplyInts(20));
        }
        [TestMethod]
        public void MultiplyIntsSuccess()
        {
            Assert.AreEqual(500, ac.MultiplyInts(5, 100));
        }
        [TestMethod]
        public void DivideByTwoAndRoundSuccess()
        {
            Assert.AreEqual(8.5, ac.DivideByTwoAndRound(17));
        }
    }
}