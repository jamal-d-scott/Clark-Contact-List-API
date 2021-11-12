using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using ClarkCodingChallenge.BusinessLogic;
using ClarkCodingChallenge.Models.MappingModels;
using System.Linq;

namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        #region Global Variables
        public IConfigurationRoot _configuration;
        public ContactsService _contactService;
        #endregion

        #region Test Methods
        // Tests successful contact add.
        [TestMethod]
        public async Task TestAddingNewContactItemAsync()
        {
            SetUp();

            ContactItem newContact = new ContactItem()
            {
                LastName = "User",
                FirstName = "New",
                EmailAddress = "newuser@test.com",
            };

            var testResult = await _contactService.AddNewContactAsync(newContact);
            Assert.AreEqual(true, testResult);
        }

        // Tests if GetContactsListAsync returns results.
        [TestMethod]
        public async Task TestGettingContactList()
        {
            SetUp();

            ContactItem newContact = new ContactItem()
            {
                LastName = "Jamal",
                FirstName = "Scott",
                EmailAddress = "jamalscott@test.com",
            };

            ContactItem newContact1 = new ContactItem()
            {
                LastName = "User",
                FirstName = "Test",
                EmailAddress = "testuser@test.com",
            };

            await _contactService.AddNewContactAsync(newContact);
            await _contactService.AddNewContactAsync(newContact1);

            var result = await _contactService.GetContactsListAsync();
            bool hasResults = result.Any();

            Assert.AreEqual(true, hasResults);
        }
        #endregion

        #region Helpers
        // Sets up our service and configuration items.
        private void SetUp()
        {
            // Create a new "mock" json to read from.
            var myConfiguration = new Dictionary<string, string>
            {
                {"API:Uri", "https://localhost:44350/api/"},
            };

            _configuration = new ConfigurationBuilder().AddInMemoryCollection(myConfiguration).Build();
            _contactService = new ContactsService(_configuration);
        }
        #endregion
    }
}
