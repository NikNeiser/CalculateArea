using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateAreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Calculate_Sides345_Area6()
        {
            double side1 = 5, side2 = 4, side3 = 3;
            double expectedArea = 6;

            FigureBase figure = new Triangle(side1,side2,side3);
            double actualArea = figure.Calculate();

            Assert.AreEqual(expectedArea,actualArea);
        }

        [TestMethod()]
        public void Triangle_RectangledSides_Rectangled()
        {
            double side1 = 5, side2 = 4;
            double side3 =Math.Sqrt(side1*side1 + side2*side2);

            Triangle triangle = new Triangle(side1, side2, side3);
            bool triangleIsRectangled = triangle.TriangleIsRectangled;

            Assert.IsTrue(triangleIsRectangled);
        }

        [TestMethod()]
        public void Triangle_NoRectangledSides_NonRectangled()
        {
            double side1 = 5, side2 = 4;
            double side3 = Math.Sqrt(side1 * side1 + side2 * side2) + 1;

            Triangle triangle = new Triangle(side1, side2, side3);
            bool triangleIsRectangled = triangle.TriangleIsRectangled;

            Assert.IsFalse(triangleIsRectangled);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),"Triangle with negative side created")]
        public void Triangle_NegativeSide_Exeption()
        {
            double side1 = 5, side2 = - 4, side3 = 3;

            FigureBase figure = new Triangle(side1, side2, side3);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Triangle with imposible sides created")]
        public void Triangle_imposibleSides_Exeption()
        {
            double side1 = 8, side2 = 4, side3 = 3;

            FigureBase figure = new Triangle(side1, side2, side3);
        }
    }
}