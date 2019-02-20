using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsClassTests
    {
        MathFunctionsClass objectUnderTest = new MathFunctionsClass();
         // Ctrl + R + R ---> Find & Replace All 

        [TestMethod()]
        public void SquareTest()
        {
       

            Assert.AreEqual(36, objectUnderTest.Square(-6), 0.001); // delta -> accuracy
            Assert.AreEqual(0, objectUnderTest.Square(0));
            Assert.AreEqual(4, objectUnderTest.Square(2));
            objectUnderTest.Square(6).ShouldBe(36);
        }

        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8, objectUnderTest.Cube(2));

            objectUnderTest.Cube(-2)
                                .ShouldBe(-8);
        }
    }
}