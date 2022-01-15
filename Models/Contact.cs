using System;
using System.Collections.Generic;
namespace VCard.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormattedName { get; set; }
        public string Organization { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Phone
    {
        public string Number { get; set; }
        public string Type { get; set; }
    }

    public class Address
    {
        public string Description { get; set; }
        public string Type { get; set; }
    }
}

