using System;
using System.Linq;
using System.Collections.Generic;
using AddressBook.Models;
using AddressBook.Data;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Services
{
    public class DatabaseAuditRepository : IAuditRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DatabaseAuditRepository (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Audit> GetAllAudits(string user)
        {
            throw new NotImplementedException();
        }

        public void Save(Audit audit)
        {
            _dbContext.Audits.Add(audit).State = EntityState.Added;
            _dbContext.SaveChanges();
        }
    }
}