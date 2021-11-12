using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using ClarkCodingChallenge.Interfaces;
using ClarkCodingChallenge.Models.MappingModels;

namespace ClarkCodingChallenge.BusinessLogic
{
    public class ContactsService : IContactService
    {
        #region Global Variables
        private HttpClient _client;
        private readonly string ApiUri;
        private IConfiguration Configuration;
        #endregion

        #region Constructors
        public ContactsService(IConfiguration _configuration)
        {
            Configuration = _configuration;
            ApiUri = Configuration.GetValue<string>("API:Uri");
        }
        #endregion

        #region Service Methods
        /// <summary>
        /// HTTP Post: Adds a new contact.
        /// </summary>
        /// <param name="item">A contact item from ContactsViewModel</param>
        /// <returns>True: If add succeeds, false otherwise.</returns>
        public async Task<bool> AddNewContactAsync(ContactItem item)
        {
            using (_client = new HttpClient())
            {
                _client.BaseAddress = new Uri(ApiUri);
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await _client.PostAsJsonAsync(_client.BaseAddress + "/contacts", item);

                return response.IsSuccessStatusCode;
            }
        }

        /// <summary>
        /// HTTP Get: Gets a list of all contacts sorted by last name, then first name ascending.
        /// </summary>
        /// <returns>A List of ContactItem</returns>
        public async Task<List<ContactItem>> GetContactsListAsync()
        {
            using (_client = new HttpClient())
            {
                _client.BaseAddress = new Uri(ApiUri);
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await _client.GetAsync(_client.BaseAddress + "/contacts");

                return response.Content.ReadAsAsync<List<ContactItem>>().Result;
            }
        }
        #endregion
    }
}
