using System;
using System.ComponentModel.DataAnnotations;

namespace PureFitnessV2.Models
{
    public class CreateProfileModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must provide a first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public char MiddleInitial { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must provide a last name.")]
        public string LastName { get; set; }

        [Display(Name = "Nickname")]
        public string NickName { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "You must provide a username.")]
        public string UserName { get; set; }

        [Display(Name = "Confirm Username")]
        [Compare("UserName", ErrorMessage = "Your Usernames do not match.")]
        public string ConfirmUserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You must provide an email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress", ErrorMessage = "Your Emails do not match.")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You must provide a longer password.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Your passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
