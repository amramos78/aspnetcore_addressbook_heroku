using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        [KeyAttribute]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [RequiredAttribute, MaxLengthAttribute(30), DisplayAttribute(Name="First Name")]
        public string FirstName { get; set; }
        [RequiredAttribute, MaxLengthAttribute(80), DisplayAttribute(Name="Last Name")]
        public string LastName { get; set; }
        [RequiredAttribute, PhoneAttribute, DisplayAttribute(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        [RequiredAttribute, EmailAddressAttribute, DisplayAttribute(Name="Email Address")]
        public string EmailAddress { get; set; }
    }
}