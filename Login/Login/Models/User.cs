using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Email Id is a required field!")]
        [EmailAddress(ErrorMessage = "Email must be in correct format !!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is a required field!")]
        [MinLength(4,ErrorMessage = "miNimun 4 charcator")]
        public string Password { get; set; }
        public String Role { get; set; }    
    }
}