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

        public int simulationMessage {get; set;}

        [BindProperty]
        public int cycleType {get; set;}

        public void OnGet()
        {
            designMessage = "Hello from design model";
            cycleType = 2;
        }

        public void OnPostRunSimulation()
        {
            simulationMessage = cycleType*2;
            

        }
    }
}
