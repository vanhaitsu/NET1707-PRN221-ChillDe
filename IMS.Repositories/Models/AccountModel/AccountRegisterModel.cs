﻿using System.ComponentModel.DataAnnotations;

namespace IMS.Repositories.AccountModel
{
    public class AccountRegisterModel
    {
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, ErrorMessage = "FullName must be no more than 50 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public Guid RoleId { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required"), Phone(ErrorMessage = "Invalid phone format")]
        [StringLength(15, ErrorMessage = "PhoneNumber must be no more than 15 characters")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(256, ErrorMessage = "Email must be no more than 256 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(256, ErrorMessage = "Address must be no more than 256 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(128, MinimumLength = 8, ErrorMessage = "Password must be from 8 to 128 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(128, MinimumLength = 8, ErrorMessage = "Confirm Password must be from 8 to 128 characters")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
