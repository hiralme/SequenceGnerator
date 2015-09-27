using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SequenceGeneratorWeb.Models
{
    public class SequenceGeneratorModel
    {
        public SequenceGeneratorModel() : this(0)
        {
        }

        public SequenceGeneratorModel(int startValue)
        {
            StartValue = startValue;
        }

        [DisplayName(@"Start Value")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Please enter valid value")]
        public int StartValue { get; private set; }

        [DisplayName(@"End Value")]
        [Range(0, Int32.MaxValue,ErrorMessage = "Please enter valid value")]
        public int? EndValue { get; set; }

        public IEnumerable<SequenceModel> Results { get; set; }
    }
}