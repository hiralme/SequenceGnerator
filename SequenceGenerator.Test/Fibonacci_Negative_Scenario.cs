using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class Fibonacci_Negative_Scenario
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_The_Start_Is_Greater_Than_The_End()
        {
            var instance = new FibonacciSequence();
            var result = instance.Generate(11, 10);
            result.ToArray();
            Assert.Fail("Should Fail...");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_The_Start_Less_Than_Zero()
        {
            var instance = new FibonacciSequence();
            var result = instance.Generate(-1, 10);
            result.ToArray();
            Assert.Fail("Should fail...");
        }
    }
}
