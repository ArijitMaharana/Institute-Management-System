using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }



        [Required(ErrorMessage = "Faculty name is required")]
        [StringLength(100)]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]+$", ErrorMessage = "Name must start with a capital letter and contain only letters and spaces")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }



        [Phone(ErrorMessage = "Invalid phone number")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Phone number must be 10 digits and start with 6-9")]
        public string Phone { get; set; }



        [Required(ErrorMessage = "Experience is required")]
        [Range(0, 50, ErrorMessage = "Experience must be between 0 and 50 years")]
        public int Experience { get; set; } // in years



        [Required(ErrorMessage = "Subjects taught is required")]
        [StringLength(300)]
        [RegularExpression(@"^[a-zA-Z0-9\s,]+$", ErrorMessage = "Subjects must contain only letters, numbers, commas, and spaces")]
        public string SubjectsTaught { get; set; }


    }

}
