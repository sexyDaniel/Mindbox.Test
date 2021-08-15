using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxSolution.Library;
using MindboxSolution.Library.Shapes;
using MindboxSolution.Library.Exceptions;

namespace MindboxSolution.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CorrectSquare()
        {
            var square = Calculator.GetSquare(new Triangle(3,4,5));

            Assert.AreEqual(6, square);
        }

        [TestMethod]
        public void IsRight() 
        {
            var triangle = new Triangle(3,4,5);
            Assert.IsTrue(triangle.IsRight());
        }

        [TestMethod]
        public void IsNotRight()
        {
            var triangle = new Triangle(5, 5, 9);
            Assert.IsFalse(triangle.IsRight());
        }

        [TestMethod]
        public void IsSideLessZero()
        {
            Assert.ThrowsException<TriangleSediesLessZeroException>(()=> new Triangle(5, 5, 0));
        }

        [TestMethod]
        public void TriangleNotExists()
        {
            Assert.ThrowsException<TriangleNotExistsException>(() => new Triangle(5, 5, 10));
        }
    }
}
