using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace enginethermo.Pages
{
    public class DesignModel : PageModel
    {
        public string designMessage { get; set; }

        public void OnGet()
        {
            designMessage = "Hello from design model";
        }
    }
}
