using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class EvenNumber_Positive_Scenario
    {
        [TestMethod]
        public void When_Generate_Normal_Sequence()
        {
            var instance = new EvenNumberSequence();
            var result = instance.Generate(0, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count());
            Assert.AreEqual("0,2,4,6,8,10", String.Join(",", result.ToArray()));
        }

        [TestMethod]
        public void When_Starts_At_Even_Then_The_Start_Value_Is_Included()
        {
            var instance = new EvenNumberSequence();
            var result = instance.Generate(2, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("2", result.First());
        }

        [TestMethod]
        public void When_Starts_At_Odd_Then_The_Start_Value_Is_Not_Included()
        {
            var instance = new EvenNumberSequence();
            var result = instance.Generate(3, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("4", result.First());
        }

        [TestMethod]
        public void When_Ends_At_Even_Then_The_End_Value_Is_Included()
        {
            var instance = new EvenNumberSequence();
            var result = instance.Generate(0, 10);
            Assert.IsNotNull(result);
            Assert.AreEqual("10", result.Last());
        }

        [TestMethod]
        public void When_Ends_At_Odd_Then_End_Value_Is_Not_Included()
        {
            var instance = new EvenNumberSequence();
            var result = instance.Generate(0, 11);
            Assert.IsNotNull(result);
            Assert.AreEqual("10", result.Last());
        }
    }
}
