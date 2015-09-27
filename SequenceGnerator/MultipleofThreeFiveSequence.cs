using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGnerator
{
    public class MultipleofThreeFiveSequence : ISequenceGenerator
    {
        public string SequenceName
        {
            get { return "MultipleofThreeFiveSequence"; }
        }
        public IEnumerable<string> Generate(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException("start", "Sequence start must be greater than the end");
            }

            for (int i = start; i<= end; i++)
            {
                var ismultiple3 = i % 3 == 0 && i != 0;
                var ismultiple5 = i % 5 == 0 && i != 0;
                if (ismultiple3 && ismultiple5)
                {
                    yield return "Z";
                }
                else if (ismultiple3)
                {
                    yield return "C";
                }
                else if (ismultiple5)
                {
                    yield return "E";
                }
                else
                {
                    yield return i.ToString();
                }
            }

           

        }
    }
}