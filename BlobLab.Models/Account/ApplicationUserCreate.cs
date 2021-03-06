using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlobLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [Required(ErrorMessage = "Fullname is required")]
        [MinLength(10, ErrorMessage = "Must be 10-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be 10-30 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MinLength(30, ErrorMessage = "Can be at most 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
