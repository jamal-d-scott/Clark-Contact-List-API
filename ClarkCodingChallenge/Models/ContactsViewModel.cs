using ClarkCodingChallenge.Models.MappingModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClarkCodingChallenge.Models
{
    public class ContactsViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public List<ContactItem> ContactList { get; set; }
    }
}
