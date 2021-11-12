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
        private HttpClient _client;
        private readonly string ApiUri;
        private IConfiguration Configuration;

        public ContactsService(IConfiguration _configuration)
        {
            Configuration = _configuration;
            ApiUri = Configuration.GetValue<string>("API:Uri");
        }

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
    }
}
