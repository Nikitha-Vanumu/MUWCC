using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonashUWCC.Models
{
    public class Training
    {
        public int Id { get; set; }

        [Display(Name = "Training location")]
        [Required(ErrorMessage = "You need to enter the training location")]
        public string Tl{ get; set; }
    }
}