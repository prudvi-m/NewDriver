using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Drivers.Models
{
    public class Driver
    {
        // EF will instruct the database to automatically generate this value
        public int DriverId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")] 
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")] 
        public string LastName { get; set; } = string.Empty;

        public string Dob { get; set;}

        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a SSN.")]
        public int? SSN { get; set; }

        public int? PostCode { get; set; }

        public string Email { get; set; } = string.Empty;

        public string License { get; set; } = string.Empty;

        public string Phone { get; set; }

        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' + SSN?.ToString();
    }
}