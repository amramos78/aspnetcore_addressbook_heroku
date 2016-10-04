using System.Threading.Tasks;
using AddressBook.Models;
using AddressBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly  IContactRepository _contactRepository;
        public ContactViewComponent (IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(Contact contact)
        {
            return View(contact);
        }
    }
}