using System.Collections.Generic;
using ClarkCodingChallenge.Api.Interfaces;
using ClarkCodingChallenge.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClarkCodingChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contacts : ControllerBase
    {
        private IContactService _contactService;

        public Contacts(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET api/Contacts
        [HttpGet]
        public ActionResult<List<Contact>> GetMailingList()
        {
            return _contactService.GetMailingList();
        }

        /*
         * GET api/Contacts/"Example"/true
         * GET api/Contacts/"Example"
         * GET api/Contacts/true
         */
        [HttpGet("{lastName?}/{true?}")]
        public ActionResult<List<Contact>> GetMailingList(string lastName = "", bool? order = null)
        {
            return _contactService.GetMailingList(lastName, order);
        }

        // POST api/Contacts
        [HttpPost]
        public void AddNewContact(Contact contact)
        {
            _contactService.AddNewContact(contact);
        }
    }
}
