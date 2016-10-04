using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [RequiredAttribute]
        [EmailAddressAttribute]
        [DisplayAttribute(Name ="Email")]
        public string EmailAddress { get; set; }

        [RequiredAttribute]
        [DataTypeAttribute(DataType.Password)]
        [StringLengthAttribute(50, ErrorMessage = "The {0} must be at least {2} and at mas {1}", MinimumLength = 6)]
        public string Password { get; set; }

        [RequiredAttribute]
        [DataTypeAttribute(DataType.Password)]
        [CompareAttribute("Password", ErrorMessage = "The password and the confirmation Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}