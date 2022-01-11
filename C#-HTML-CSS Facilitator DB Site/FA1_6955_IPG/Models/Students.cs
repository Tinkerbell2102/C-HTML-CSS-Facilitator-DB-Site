using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FA1_6955_IPG.Models
{
    public class Students
    {
        [Key]
        [Required]
        [Display(Name = "Student Number")]
        public String StudentNo { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required]
        [Display(Name = "Address1")]
        public String Address1 { get; set; }
        
        [Required]
        [Display(Name = "Address2")]
        public String Address2 { get; set; }
       
        [Required]
        [Display(Name = "Email")]
        public String Email { get; set; }
        
    } 
}