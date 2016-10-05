using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Audit
    {
        [KeyAttribute]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed)]
        public DateTime Created {get;set;}

        [RequiredAttribute]
        public string User {get;set;}

        public string Message {get; set;}

    }
}