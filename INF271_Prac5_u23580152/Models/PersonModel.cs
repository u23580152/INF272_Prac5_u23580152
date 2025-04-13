﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INF271_Prac5_u23580152.Models
{
    public class PersonModel
    {
    
        [Display(Name = "Student number")] 
        public string StuNumber { get; set; }

        [Display(Name = "First Name")] 
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] 
        public string LastName { get; set; }

        [Display(Name = "Email address")] 
        public string Email { get; set; }

       

        public PersonModel()
        {

        }
    }
}
