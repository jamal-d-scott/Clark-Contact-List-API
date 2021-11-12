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
        #region Global Variables
        private IContactService _contactService;
        #endregion

        #region Constructors
        public Contacts(IContactService contactService)
        {
            _contactService = contactService;
        }
        #endregion

        #region Service Functions
        // POST api/Contacts
        [HttpPost]
        public void AddNewContact(Contact contact)
        {
            _contactService.AddNewContact(contact);
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
        [HttpGet("{lastName?}/{order?}")]
        public ActionResult<List<Contact>> GetMailingList(string lastName = "", bool? order = null)
        {
            lastName = lastName.ToLower();
            string queryLastName;
            bool? orderFlag;

            // Tricky, but we're going to assume if you're searching by 'true' or 'false' you're attempting to sort.
            // If searching for a last name of 'true' or 'false', you'll need to provide an ordering.
            // How can we take in these params better?
            if (lastName.Equals("true") || lastName.Equals("false"))
            {
                if(order == null)
                {
                    queryLastName = "";
                    orderFlag = lastName.Equals("true") ? true : false;
                }
                else
                {
                    queryLastName = lastName;
                    orderFlag = order;
                }
            }
            else
            {
                queryLastName = lastName;
                orderFlag = order;
            }

            return _contactService.GetMailingList(queryLastName, orderFlag);
        }
        #endregion
    }
}
