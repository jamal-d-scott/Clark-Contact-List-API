using ClarkCodingChallenge.Api.Interfaces;
using ClarkCodingChallenge.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.Api.Services
{
    public class ContactsService : IContactService
    {
        // Make a static instance of MAILINGLIST to be used during the duration of the application.
        private static List<Contact> MAILINGLIST = new List<Contact>();

        public List<Contact> GetMailingList()
        {
            return GetOrderedResults().ToList();
        }

        public List<Contact> GetMailingList(string lastName = "", bool? order = null)
        {
            lastName = lastName.ToLower();

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                // Grab a list based on the ordering and filtering out by last name
                return GetOrderedResults(order).Where(x => x.LastName.ToLower().Equals(lastName)).ToList();
            }
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                return GetOrderedResults(order).ToList();
            }
            else
            {
                return GetOrderedResults(order).ToList();
            }
        }

        // Sort based the presence or lack of presence of a nullable boolean.
        private IEnumerable<Contact> GetOrderedResults(bool? ordering = null)
        {
            // Conditional ordering based on the boolean flag.
            switch (ordering)
            {
                case true:
                    return MAILINGLIST.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
                case false:
                    return MAILINGLIST.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName);
            }

            // Default condition: If no ordering was present, we'll sent the list back in ascending order.
            return MAILINGLIST.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
        }

        public void AddNewContact(Contact contact)
        {
            MAILINGLIST.Add(contact);
        }
    }
}
