using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceGnerator
{
    public interface ISequenceGenerator
    {
        string SequenceName { get; }
        IEnumerable<string> Generate(int start, int end);
    }
}
