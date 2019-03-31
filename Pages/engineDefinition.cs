using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace enginethermo.Models
{
    public class engineDefinition
    {

        [BindProperty]
        [Required]
        [Display(Name = "Cycle Type")]
        public string cycleType {get; set;} = "SI";

        [BindProperty]
        [Required]
        [Display(Name = "Cylinder Displacement")]
        public int cylinderDisplacement {get; set;}

        [BindProperty]
        [Required]
        [Display(Name = "Cylinder Clearance")]
        public int cylinderClearance {get; set;}

        [BindProperty]
        [Required]
        [Range(1,20)]
        [Display(Name = "Cylinder Count")]
        public int cylinderCount {get; set;} = 1;


    }

}