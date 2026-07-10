using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()//Test method names are long as we have to use it in descriptive manner 
        {
            //Arrange  - means we have to do the initializations
            Calculator calc = new();

            //Act - Invoke or call the methods that are needed to give some output
            int result = calc.AddNumbers(10, 20);

            //Assert - In this we check the result is as expected.
            ClassicAssert.AreEqual(30, result); 
        }
    }
}
