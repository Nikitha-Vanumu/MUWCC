using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonashUWCC.Models
{
    public class Captain
    {

        
        public int Id { get; set; }

        [Display(Name = "Captain Name")]
        [Required(ErrorMessage = "You need to enter the Captain Name")]
        public string CaptainName { get; set; }

        [Display(Name = "Vice-Captain Name")]
        [Required(ErrorMessage = "You need to enter the ViceCaptain Name")]
        public string ViceCaptainName { get; set; }

        [Display(Name = "Team")]
        [Required(ErrorMessage = "You need to enter the Team Name")]
        public string Team { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "You need to enter the Year")]
        public string Year { get; set; }
    }
}