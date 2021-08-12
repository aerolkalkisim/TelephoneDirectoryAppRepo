using System;
using System.Collections.Generic;
using System.Linq;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.Mapped
{
    public class ContactMapping
    {
        public List<ContactWM> MapToWMList(List<Contact> modelEntity)
        {
            return modelEntity.Select(x => new ContactWM
            {
                Name = x.Name,
                Surname = x.Surname,
                Firm = x.Firm

            }).ToList();
        }

        public Contact MapToEntitiy(ContactWM modelWM)
        {
            return new Contact
            {
                Name = modelWM.Name,
                Surname = modelWM.Surname,
                Firm = modelWM.Firm,
                IsActive=true

            };
        }
    }
}
