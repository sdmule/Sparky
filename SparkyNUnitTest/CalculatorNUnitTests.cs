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

        //Below method is my first try to write Unit Test on first assignment, some improvements were there but I learned and I am happy for that 
        //[Test]
        //public void CheckOddNumbers_InputOneInt_IsOddNumber()
        //{
        //    Calculator calc = new();

        //    bool result = calc.CheckOddNumbers(3);

        //    ClassicAssert.AreEqual(true, result);
        //}

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            Calculator calculator = new();

            bool isOdd = calculator.IsOddNumber(10);

            ClassicAssert.That(isOdd, Is.EqualTo(false));
            //ClassicAssert.IsFalse(isOdd); -------> Here are another ways and output of all ways will be same.
        }

        //[Test]
        //public void IsOddChecker_InputOddNumber_ReturnTrue()
        //{
        //    Calculator calculator = new();

        //    bool isOdd = calculator.IsOddNumber(11);

        //    ClassicAssert.That(isOdd, Is.EqualTo(true));
        //    //ClassicAssert.IsTrue(isOdd); //Here are another ways and output of all ways will be same.
        //}


        //If we have to test multiple values then below is the way using "[TestCase]"
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        //Here if we have multiple parameters in method then use comma to separate that and pass it
        //e.g. - [TestCase(11, 12)] // If we have two parameters for the method
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            Calculator calculator = new();

            bool isOdd = calculator.IsOddNumber(a);

            ClassicAssert.That(isOdd, Is.EqualTo(true));
            ClassicAssert.IsTrue(isOdd);
        }
    }
}
