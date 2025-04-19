using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name Field Cannot Be Left As Empty")]
        public string Name { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Field Cannot Be Left As Empty")]
        public string EmailAddress {  get; set; }



        [Required(ErrorMessage = "Mobile Field Cannot Be Left As Empty")]
        public string Mobile {  get; set; }


        public int CourseId { get; set; }


        [Required(ErrorMessage = "Gender Field Cannot Be Left As Empty")]
        public string Gender { get; set; }

        public DateTime DateOfRegistration { get; set; } = DateTime.Now;

        public string FeeStatus { get; set; } = "Unpaid";


        [Required( ErrorMessage = "Address Field Cannot Be Left As Empty")]
        public string Address { get; set; }


        public Course Course { get; set; }
    }
}