using System;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.Mapped
{
    public class ContactInformationTypeMapping
    {
        public ContactInformationType MapToEntity(ContactInformationTypeWM model)
        {
            return new ContactInformationType()
            {
                Name = model.Name
            };
        }
    }
}
