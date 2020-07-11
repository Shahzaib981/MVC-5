using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViewToController.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter your name")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Please Enter your lastname")]
        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }
        
        [Required]
        [Range(18,100)]
        public int age { get; set; }
    }
}