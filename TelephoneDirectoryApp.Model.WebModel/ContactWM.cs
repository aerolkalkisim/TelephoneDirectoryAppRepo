using System;
using System.Collections.Generic;

namespace TelephoneDirectoryApp.Model.WebModel
{

    public class ContactWM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Firm { get; set; }
        public List<ContactInformationWM> ContactInformations { get; set; }

    }
}
