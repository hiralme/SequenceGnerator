using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class OddNumber_Positive_Scenario
    {
        [TestMethod]
        public void When_Generate_Normal_Sequence()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(0, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            Assert.AreEqual("1,3,5,7,9", String.Join(",", result.ToArray()));
        }

        [TestMethod]
        public void When_Starts_At_Odd_Then_The_Start_Value_Is_Included()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(1, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("1", result.First());
        }

        [TestMethod]
        public void When_Starts_At_Even_Then_The_Start_Value_Is_Not_Included()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(2, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("3", result.First());
        }

        [TestMethod]
        public void When_Ends_At_Odd_Then_The_End_Value_Is_Included()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(0, 11);
            Assert.IsNotNull(result);
            Assert.AreEqual("11", result.Last());
        }

        [TestMethod]
        public void When_Ends_At_Even_Then_End_Value_Is_Not_Included()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(0, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("9", result.Last());
        }
    }
}
