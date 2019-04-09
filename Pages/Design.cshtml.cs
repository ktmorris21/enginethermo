using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using enginethermo;

namespace enginethermo.Pages
{
    public class DesignModel : PageModel
    {
        [BindProperty]
        public engineDefinition engineDefinition {get; set;} = new engineDefinition();
   
        public string simulationMessage {get; set;} = "Not run";

        public List<SelectListItem> cycleTypes {get;} = new List<SelectListItem>
        {
            new SelectListItem {Value="SI", Text = "Spark Ignition (Otto Cycle)"},
            new SelectListItem {Value="CI", Text = "Compressoin Ignition (Diesel Cycle)"},
        };

        public void OnGet()
        {
            simulationMessage = "Not run";
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // Good validation, proceed
                simulationMessage = "simulated";
            }
            else
            {
                // Input validation failed
                simulationMessage = "error";
            }
        }
    }
}
