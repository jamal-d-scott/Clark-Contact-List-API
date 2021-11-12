using ClarkCodingChallenge.Models.MappingModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Interfaces
{
    public interface IContactService
    {
        Task<bool> AddNewContactAsync(ContactItem item);

        Task<List<ContactItem>> GetContactsListAsync();
    }
}
