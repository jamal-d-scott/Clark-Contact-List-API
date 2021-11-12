using ClarkCodingChallenge.Api.Interfaces;
using ClarkCodingChallenge.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.Api.Services
{
    public class ContactsService : IContactService
    {
        #region Global Variables
        private static List<Contact> MAILINGLIST = new List<Contact>();
        #endregion

        #region Service Functions
        /// <summary>
        /// Adds a new contact item to the MAILINGLIST collection.
        /// </summary>
        /// <param name="contact">A contact item: firstName, lastName, emailAddress</param>
        public void AddNewContact(Contact contact)
        {
            MAILINGLIST.Add(contact);
        }

        /// <summary>
        /// Returns an ordered list of contact items.
        /// </summary>
        /// <returns>An ordered list of contacts. Default order by ascending</returns>
        public List<Contact> GetMailingList()
        {
            return GetOrderedResults().ToList();
        }

        /// <summary>
        /// REST endpoint allowing URL querying of contact items.
        /// </summary>
        /// <param name="lastName">A contact's last name. OPTIONAL</param>
        /// <param name="order">Sorting Order. OPTIONAL</param>
        /// <returns>An ordered list of contact items based on paremeters</returns>
        public List<Contact> GetMailingList(string lastName = "", bool? order = null)
        {
            if (!string.IsNullOrWhiteSpace(lastName))
            {
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
        #endregion

        #region Helpers.
        /// <summary>
        /// Helper method to order the MAILINGLISt collection.
        /// </summary>
        /// <param name="ordering">Order direction. OPTIONAL</param>
        /// <returns>An ordered IEnumerable of contact items</returns>
        private IEnumerable<Contact> GetOrderedResults(bool? ordering = null)
        {
            switch (ordering)
            {
                case true:
                    return MAILINGLIST.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
                case false:
                    return MAILINGLIST.OrderByDescending(x => x.LastName).ThenByDescending(x => x.FirstName);
            }

            return MAILINGLIST.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);
        }
        #endregion
    }
}
