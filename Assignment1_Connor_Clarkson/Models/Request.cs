using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_Connor_Clarkson.Models
{
    public enum Category { Laptop, Phone, Tablet, Another }
    public class Request
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [RegularExpression(@"^[2-9]\d{2}\d{3}\d{4}$",
            ErrorMessage = "Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Select a Role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Please Give a Reason For Your Request")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Please Enter a the Number of Days Requesting")]
        [RegularExpression("^[1-9][0-9]*$",
            ErrorMessage = "Please Enter a Valid Reason")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Please Select an Equipment Category")]
        public Category Equipment { get; set; }

        public int Id { get; set;}

    }
}
