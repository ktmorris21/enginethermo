using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace enginethermo.Pages
{
    public class DesignModel : PageModel
    {

        public string simulationMessage {get; set;} = "Not run";

        [BindProperty]
        [Required]
        [Display(Name = "Cycle Type")]
        public string cycleType {get; set;} = "SI";

        public List<SelectListItem> cycleTypes {get;} = new List<SelectListItem>
        {
            new SelectListItem {Value="SI", Text = "Spark Ignition (Otto Cycle)"},
            new SelectListItem {Value="CI", Text = "Compressoin Ignition (Diesel Cycle)"},
        };
        
        [BindProperty]
        [Required]
        [Range(1,20)]
        [Display(Name = "Cylinder Count")]
        public int cylinderCount {get; set;} = 1;

        public void OnGet()
        {
            
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
