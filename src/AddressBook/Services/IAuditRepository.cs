using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Services
{
    public interface IAuditRepository
    {
        void Save(Audit audit);
        IEnumerable<Audit> GetAllAudits(string user);
    }
}
