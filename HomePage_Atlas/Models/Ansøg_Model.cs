using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomePage_Atlas.Models
{
    public class Ansøg_Model
    {
        public bool IsTrue { get { return true; } }
        /* NAVN */
        [Display(Name = "Fulde navn")]
        [Required(ErrorMessage = "Udfyld venligst dit navn")]
        public string Name { get; set; }
        /* EMAIL */
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Udfyld venligst din email")]
        public string Email { get; set; }
    }
}
