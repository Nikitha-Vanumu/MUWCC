using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonashUWCC.Models
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }

        [Display(Name = "Coach Name")]
        [Required(ErrorMessage = "You need to enter the Coach Name")]
        public string CoachName { get; set; }

       
        [Display(Name = "Position")]
        [Required(ErrorMessage = "You need to enter the Team Name")]
        public string Team { get; set; }

        [Display(Name = " Date of Joining ")]
        [Required(ErrorMessage = "You need to  enter the data of joining")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfJoining { get; set; }
        
    }
}