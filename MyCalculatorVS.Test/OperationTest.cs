using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorVS.Test
{
    [TestFixture]
    public class OperationTest
    {
        private Calculation _operation;
        
        [SetUp]
        public void SetUp()
        {
            _operation = new Calculation();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfNumbers()
        {

            var result = _operation.Add(7, 8);

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnTheDifferenceOFNumbers()
        {
            var result = _operation.Subtract(7, 5);

            Assert.That(result, Is.EqualTo(2));
        }


        [Test]
        public void Divide_WhenCalled_DivisionOfNumbers()
        {
            var result = _operation.Divide(6, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _operation.Multiply(9, 5);

            Assert.That(result, Is.EqualTo(45));
        }
    }
}
