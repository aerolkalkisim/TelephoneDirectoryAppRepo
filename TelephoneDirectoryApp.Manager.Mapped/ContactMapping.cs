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
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Firm = x.Firm

            }).ToList();
        }

        public ContactWM MapToWM(Contact modelEntity)
        {
            return new ContactWM
            {
                Id = modelEntity.Id,
                Name = modelEntity.Name,
                Surname = modelEntity.Surname,
                Firm = modelEntity.Firm

            };
        }

        public Contact MapToEntitiy(ContactWM modelWM)
        {
            return new Contact
            {
                Id = modelWM.Id,
                Name = modelWM.Name,
                Surname = modelWM.Surname,
                Firm = modelWM.Firm,
                IsActive = true

            };
        }

        public List<ContactInformationWM> MapToWMListForInformation(List<ContactInformation> modelEntity)
        {
            return modelEntity.Select(x => new ContactInformationWM
            {
                Id = x.Id,
                Value = x.Value,
                TypeName = x.ContactInformationType.Name

            }).ToList();
        }

        public ContactInformationWM MapToWMLForInformation(ContactInformation x)
        {
            return new ContactInformationWM
            {
                Id = x.Id,
                Value = x.Value,
                TypeId=x.TypeId

            };
        }


        public ContactInformation MapToEnttiyForInformation(ContactInformationWM modelWM)
        {
            return new ContactInformation()
            {
                Id=modelWM.Id,
                ContactId = modelWM.ContactId,
                TypeId = modelWM.TypeId,
                IsActive = true,
                Value = modelWM.Value
            };
        }
    }
}
