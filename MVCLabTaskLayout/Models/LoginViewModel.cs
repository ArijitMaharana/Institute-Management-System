using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class LoginViewModel
    {
        [Display(Name = "User Id")]
        [Required(ErrorMessage = "User Id Field Cannot Be Left As Empty")]
        public string Userid { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Field Cannot Be Left As Empty")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
    ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character (e.g., @, $, !, %, *, ?, &).")]
        public string Password { get; set; }
    }
}