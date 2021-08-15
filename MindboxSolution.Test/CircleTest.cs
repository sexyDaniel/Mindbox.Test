using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxSolution.Library;
using MindboxSolution.Library.Shapes;
using MindboxSolution.Library.Exceptions;
using System;

namespace MindboxSolution.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CorrectSquare()
        {
            var square = Calculator.GetSquare(new Circle(4));
            var currectSquare = Math.PI * 4 * 4;

            Assert.AreEqual(currectSquare, square);
        }

        [TestMethod]
        public void UncorrectRadius()
        {
            Assert.ThrowsException<CircleRadiusLessZeroException>(()=>new Circle(-10));
        }
    }
}
