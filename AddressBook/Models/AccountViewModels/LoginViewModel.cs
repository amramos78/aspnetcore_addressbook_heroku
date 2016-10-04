using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [RequiredAttribute]
        [EmailAddressAttribute]
        public string EmailAddress { get; set; }
        
        [RequiredAttribute]
        [DataTypeAttribute(DataType.Password)]
        public string Password { get; set; }
    }
}