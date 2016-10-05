using Microsoft.EntityFrameworkCore;
using AddressBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AddressBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts {get; set;}

        public DbSet<Audit> Audits {get; set;}
    }
}