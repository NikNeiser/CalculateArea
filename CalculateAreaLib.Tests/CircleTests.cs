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
    public class CircleTests
    {

        [TestMethod()]
        public void Calculate_2_4xPi()
        {            
            double radius = 2;
            double expectedArea = 4*Math.PI;
            
            Circle c = new Circle(radius);
            double actualArea = c.Calculate();
            
            Assert.AreEqual(expectedArea,actualArea);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Created circle with negative radius")]
        public void Circle_NegativeRadius_Exeption()
        {
            double radius = -5;

            FigureBase figure = new Circle(radius);
        }
    }
}