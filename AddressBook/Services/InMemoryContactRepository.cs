using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Models;

namespace AddressBook.Services
{
    public class InMemoryReporitory : IContactRepository
    {
        private List<Contact> _contacts = new List<Contact>()
        {
            new Contact { Id = 1, FirstName = "Alejandro", LastName = "Ramos", PhoneNumber = "1133556666", EmailAddress = "alejandro@live.com.ar" },
            new Contact { Id = 2, FirstName = "Juan", LastName = "Perez", PhoneNumber = "567898765", EmailAddress = "Juan@hotmail.com" },
            new Contact { Id = 3, FirstName = "Jhon", LastName = "Doe", PhoneNumber = "2323442434", EmailAddress = "jhon@doe.com" }
        };

        public void AddContact(Contact contact)
        {
            contact.Id = _contacts.Max(c => c.Id) + 1;
            _contacts.Add(contact);
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public Contact GetContact(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}