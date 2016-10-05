using System;
using System.Linq;
using System.Collections.Generic;
using AddressBook.Models;
using AddressBook.Data;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Services
{
    public class DatabaseContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DatabaseContactRepository (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact).State = EntityState.Added;

            _dbContext.SaveChanges();
        }

        public void DeleteContact(int Id)
        {
            var contact = GetContact(Id);
            _dbContext.Contacts.Remove(contact).State = EntityState.Deleted;

            _dbContext.SaveChanges();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _dbContext.Contacts;
        }

        public Contact GetContact(int Id)
        {
            return _dbContext.Contacts.SingleOrDefault(c => c.Id == Id);
        }

        public void UpdateContact(Contact contact)
        {
            _dbContext.Contacts.Update(contact);
            _dbContext.SaveChanges();
        }
    }
}