using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using System.Threading.Tasks;
using ClarkCodingChallenge.Interfaces;
using AutoMapper;
using ClarkCodingChallenge.Models.MappingModels;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IMapper _mapper;
        private IContactService _contactService;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _mapper = mapper;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(new ContactsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddNewContact(ContactsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var newContactItem = _mapper.Map<ContactItem>(vm);

                var result = await _contactService.AddNewContactAsync(newContactItem);

                if (result)
                {
                    return RedirectToAction("SubmitSuccessful", "Success");
                }
                else
                {
                    return RedirectToAction("ShowErrorPage", "Error");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMailingList()
        {
            var contactList = await _contactService.GetContactsListAsync();

            var resultsVM = new ContactsViewModel()
            {
                ContactList = contactList
            };
            return View("ContactList", resultsVM);
        }
    }
}
