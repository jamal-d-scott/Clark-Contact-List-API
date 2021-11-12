using ClarkCodingChallenge.Api.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.Api.Interfaces
{
    public interface IContactService
    {
        void AddNewContact(Contact contact);

        List<Contact> GetMailingList();

        List<Contact> GetMailingList(string lastName = "", bool? order = null);
    }
}
