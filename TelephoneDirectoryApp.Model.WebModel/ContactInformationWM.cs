using System;

namespace TelephoneDirectoryApp.Model.WebModel
{
    public class ContactInformationWM
    {
        public string Id { get; set; }
        public ContactInformationTypeWM Type { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
