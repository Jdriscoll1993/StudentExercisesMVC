using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {
        [Display(Name = "Exercise Id")]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Instructor Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Programming Language")]
        public string Language { get; set; }
    }
}
