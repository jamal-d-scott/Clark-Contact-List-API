using ClarkCodingChallenge.Api.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Api.Interfaces
{
    public interface IContactService
    {
        List<Contact> GetMailingList();

        List<Contact> GetMailingList(string lastName = "", bool? order = null);

        void AddNewContact(Contact contact);
    }
}
