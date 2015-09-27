using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGnerator
{
    public class AllNumberSequence : ISequenceGenerator
    {
        public string SequenceName
        {
            get { return "AllNumberSequence"; }
        }

        public IEnumerable<string> Generate(int start,int end)
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException("start", "Sequence start must be greater than the end");
            }

            return Enumerable.Range(start, end+1).Select(i => i.ToString());

        }

    }
}