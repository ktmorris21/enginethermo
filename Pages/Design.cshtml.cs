using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace enginethermo.Pages
{
    public class DesignModel : PageModel
    {

        public string designMessage { get; set; }

        public string simulationMessage {get; set;}

        [BindProperty]
        [Required]
        [StringLength(5)]
        [Display(Name = "Cycle Type")]
        public string cycleType {get; set;}

        public void OnGet()
        {
            designMessage = "Hello from design model";
            cycleType = "hi";
        }

        public void OnPostRunSimulationAsync()
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
            
            simulationMessage = "executed";
            
            // Pickup: How to make this validation do automatic things (client side notification, server side notification)
            

        }
    }
}
