using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class Fibonacci_Positive_Scenario
    {
        [TestMethod]
        public void When_Generate_Normal_Sequence()
        {
            var instance = new FibonacciSequence();
            var result = instance.Generate(0, 15);
            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Count());
            Assert.AreEqual("0,1,1,2,3,5,8,13", String.Join(",", result.ToArray()));
        }

        [TestMethod]
        public void When_Generate_Large_Sequence()
        {
            var instance = new FibonacciSequence();
            var result = instance.Generate(0, 100);
            Assert.IsNotNull(result);
            Assert.AreEqual(12, result.Count());
            Assert.AreEqual("0,1,1,2,3,5,8,13,21,34,55,89", String.Join(",", result.ToArray()));
        }
    }
}
