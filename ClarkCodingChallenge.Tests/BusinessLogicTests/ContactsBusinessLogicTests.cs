using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using ClarkCodingChallenge.Controllers;
using ClarkCodingChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.BusinessLogic;
using ClarkCodingChallenge.Models.MappingModels;

namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        [TestMethod]
        public async Task TestAddingNewContactItemAsync()
        {
            var myConfiguration = new Dictionary<string, string>
            {
                {"API:Uri", "https://localhost:44350/api/"},
            };

            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();

            var contactCont = new ContactsService(configuration);

            ContactItem newContact = new ContactItem()
            {
                LastName = "User",
                FirstName = "New",
                EmailAddress = "test@test.com",
            };

            var testResult = await contactCont.AddNewContactAsync(newContact);
            Assert.AreEqual(true, testResult);
        }
    }
}
