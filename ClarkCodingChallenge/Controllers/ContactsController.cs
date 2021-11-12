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
        #region Global Variables
        private readonly IMapper _mapper;
        private IContactService _contactService;
        #endregion

        #region Constructors
        /// <summary>
        /// Imports a mapper and ContactService from Dependency Injection.
        /// </summary>
        /// <param name="contactService"></param>
        /// <param name="mapper"></param>
        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _mapper = mapper;
            _contactService = contactService;
        }
        #endregion

        #region Default View
        public IActionResult Index()
        {
            return View(new ContactsViewModel());
        }
        #endregion

        #region Form Actions
        /// <summary>
        /// Adds a new contact to the contacts list.
        /// </summary>
        /// <param name="vm">ContactsViewModel from Index.cshtml form</param>
        /// <returns>A view</returns>
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

        /// <summary>
        /// Gets a list of all contacts.
        /// </summary>
        /// <returns>The contact list table view</returns>
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
        #endregion
    }
}
