using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Services
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();

        void AddContact(Contact contact);
        Contact GetContact(int Id);
        void UpdateContact(Contact contact);
        void DeleteContact(int Id);
    }
}