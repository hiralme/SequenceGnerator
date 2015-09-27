using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGeneratorWeb.Models
{
    public class SequenceModel
    {
        public SequenceModel()
        {
            Values = Enumerable.Empty<string>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}