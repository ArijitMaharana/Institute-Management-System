﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class RegisterAdmin
    {
        [Key]
        public string UserId {  get; set; }
        public string Password {  get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Mobile {  get; set; }
        public bool Status { get; set; }
    }
}