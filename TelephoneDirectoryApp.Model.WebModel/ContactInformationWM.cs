using System;

namespace TelephoneDirectoryApp.Model.WebModel
{
    public class ContactInformationWM
    {
        public Guid Id { get; set; }
        public Guid ContactId { get; set; }
        public Guid TypeId { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
    }
}
