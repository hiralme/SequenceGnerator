using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class AllNumbers_Positive_Scenario
    {
        [TestMethod]
        public void When_End_Value_is_small()
        {
            var instance = new AllNumberSequence();
            var result = instance.Generate(0, 5);
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count());
            Assert.AreEqual("0,1,2,3,4,5", String.Join(",", result.ToArray()));
        }

        [TestMethod]
        public void Then_Start_Value_Included()
        {
            var instance = new AllNumberSequence();
            var result = instance.Generate(0, 5);
            Assert.IsNotNull(result);
            Assert.AreEqual("0", result.First());
        }

        [TestMethod]
        public void Then_End_Value_Included()
        {
            var instance = new AllNumberSequence();
            var result = instance.Generate(0, 5);
            Assert.IsNotNull(result);
            Assert.AreEqual("5", result.Last());
        }

        [TestMethod]
        public void When_End_Value_is_large()
        {
            var instance = new AllNumberSequence();
            var result = instance.Generate(0, 2147483645);
            Assert.IsNotNull(result);
            Assert.AreEqual(2147483646, result.Count());
        }
    }
}
