using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SequenceGnerator;
using SequenceGeneratorWeb.Models;
using System.Net;
using SequenceGeneratorWeb.Content;

namespace SequenceGeneratorWeb.Controllers
{
    public class SequenceController : Controller
    {
        private readonly IEnumerable<ISequenceGenerator> _generator;

        public SequenceController()
        {
            
        }

        public SequenceController(ISequenceGenerator[] generator)
        {
            _generator = generator;
        }
        
        // GET: Sequence
        public ActionResult Index(SequenceGeneratorModel model)
        {
            if (ModelState.IsValid && model.EndValue.HasValue)
            {
                model.Results = _generator.Select(c => new SequenceModel()
                {
                    Title = SequenceGeneratorDetails.ResourceManager.GetString(String.Format("{0}_Header", c.SequenceName)),
                    Description = SequenceGeneratorDetails.ResourceManager.GetString(String.Format("{0}_Description", c.SequenceName)),
                    Values = c.Generate(model.StartValue, model.EndValue.GetValueOrDefault(0))
                });
            }
            return View("Index", model);
        }

    }
}