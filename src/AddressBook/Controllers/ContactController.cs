using AddressBook.Models;
using AddressBook.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        
        public ContactController (IContactRepository contactRepository)
        {
          this._contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            var model = _contactRepository.GetAllContacts();

            return View(model);
            //return View("IndexPartialView", model);
            //return View("IndexViewComponent", model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact)
        {
            if(ModelState.IsValid)
            {
                _contactRepository.AddContact(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        public IActionResult Edit(int id)
        {
            var contact = _contactRepository.GetContact(id);
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Contact contact)
        {
            if(ModelState.IsValid)
            {
                _contactRepository.UpdateContact(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _contactRepository.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}