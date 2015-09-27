using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGnerator
{
    public class FibonacciSequence : ISequenceGenerator
    {
        public string SequenceName
        {
            get { return "FibonacciSequence"; }
        }

        public IEnumerable<string> Generate(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException("start", "Start must be greater than the end");
            }

            if (start < 0)
            {
                throw new ArgumentOutOfRangeException("start", "Start must be greater than 0");
            }

            Int64 previous = 0, next = 1; 
            do
            {
                if (previous >= start)
                {
                    yield return previous.ToString();
                }

                var temp = previous;
                previous = next;
                next = temp + next;
            }
            while (previous <= end);

        }
    }
}