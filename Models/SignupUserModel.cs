using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseFromApplication.Models
{
    public class SignupUserModel
    {
       
            [Required(ErrorMessage = "Please enter your Email")]
            [Display(Name = "Email Address")]
            [EmailAddress(ErrorMessage ="Please enter your email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please enter a Password")]
            [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
            [Display(Name = "Password")]
            [DataType(DataType.Password)]

            public string Password { get; set; }

            [Required(ErrorMessage = "Please confirm your Password")]
            [Display(Name = "ConfirmPassword")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
        
    }
}