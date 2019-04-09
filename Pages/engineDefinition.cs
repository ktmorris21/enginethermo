using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace enginethermo
{
    public class engineDefinition
    {

        [Required]
        [Display(Name = "Cycle Type")]
        public string cycleType {get; set;} = "SI";

        [Required]
        [Display(Name = "Cylinder Displacement")]
        [Range(0.000001, float.MaxValue, ErrorMessage="Cylinder displacement must be greater than 1cc.")]
        public float cylinderDisplacement {get; set;}

        [Required]
        [Display(Name = "Cylinder Clearance")]
        [Range(0.00000001, float.MaxValue, ErrorMessage="Cylinder clearance must be greater than 0.1cc.")]
        public float cylinderClearance {get; set;}

        [Required]
        [Range(1,20)]
        [Display(Name = "Cylinder Count")]
        public int cylinderCount {get; set;} = 1;


    }

}