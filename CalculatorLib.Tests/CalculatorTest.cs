using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase]
        public void Add_When_Both_Inputs_GreaterThanZero_Returns_ExpectedResult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int firstNo = 30;
            int secondNo = 20;

            int expectedResult = 50;

            int actualResult;

            //Act

            actualResult = calculator.Add(firstNo, secondNo);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
           
        }

        [Test]
        public void Add_When_FirstInputGreaterThanZero_SecondInputLessThanOrEqualToZero_Returns_ExpectedResult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int firstNo = 30;
            int secondNo = 0;

            int expectedResult = -1;

            int actualResult;

            //Act

            actualResult = calculator.Add(firstNo, secondNo);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Add_When_SecondInputGreaterThanZero_FirstInputLessThanOrEqualToZero_Returns_ExpectedResult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int firstNo = -5;
            int secondNo = 20;

            int expectedResult = -2;

            int actualResult;

            //Act

            actualResult = calculator.Add(firstNo, secondNo);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Add_When_Both_Inputs_LessThanOrEqualToZero_Returns_ExpectedResult()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int firstNo = -5;
            int secondNo = 0;

            int expectedResult = 0;

            int actualResult;

            //Act

            actualResult = calculator.Add(firstNo, secondNo);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

    }
}
