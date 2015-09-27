using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class MultipleofThreeFive_Positive_Scenario
    {
        [TestMethod]
        public void When_Generate_Normal_Sequence()
        {
            var instance = new MultipleofThreeFiveSequence();
            var result = instance.Generate(0, 15);
            Assert.IsNotNull(result);
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("Z", result.Last());
            Assert.AreEqual("0,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z", String.Join(",", result.ToArray()));
        }

    }
}
