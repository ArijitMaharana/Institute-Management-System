using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class RegisterAdminViewModel
    {
        
        [Display(Name = "User Id")]
        [Required(ErrorMessage = "User Id Cannot Be Left As Empty")]
        [RegularExpression("[A-Za-z0-9]{6,20}", ErrorMessage = "User Id value is invalid.")]
        public string UserId { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Passsword Field Can not Be Left As Empty")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
    ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character (e.g., @, $, !, %, *, ?, &).")]
        public string Password { get; set; }


        [Display(Name = "confirm Password")]
        [Required(ErrorMessage = "Confirm password Field Cannot Be Left As Empty")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Username Cannot Be left As Empty")]
        [RegularExpression("[A-Za-z\\s]{3,50}", ErrorMessage = "Name Value Is Invalid")]
        public string Name { get; set; }



        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Field Cannot Be Left As Empty")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Mobile Field Cannot Be Left As Empty")]
        [RegularExpression("[6-9]\\d{9}", ErrorMessage = "Phone is invalid.")]
        public string Mobile { get; set; }
    }
}