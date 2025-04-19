using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class StudentCourseViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }        
        public string EmailAddress { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfRegistration { get; set; } 
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public double Fees { get; set; }
        public string Duration { get; set; }
        public string Address { get; set; }
        public string FeeStatus { get; set; }

    }
}