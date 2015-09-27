using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SequenceGnerator;

namespace SequenceGenerator.Test
{
    [TestClass]
    public class OddNumber_Negative_Scenario
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_Start_Is_Greater_Than_End()
        {
            var instance = new OddNumberSequence();
            var result = instance.Generate(11, 10);
            result.ToArray();
            Assert.Fail("Should Fail");
        }
    }
}
