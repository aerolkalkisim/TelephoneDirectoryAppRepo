using System;
using TelephoneDirectoryApp.Core.Exception.BusinessException;
using TelephoneDirectoryApp.Data.Repository;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.WebManager
{
    public class ContactInformationTypeManager : IContactInformationTypeManager
    {
        private readonly IContactInformationTypeRepository _contactInformationTypeRepository;

        public ContactInformationTypeManager(IContactInformationTypeRepository contactInformationTypeRepository)
        {
            _contactInformationTypeRepository = contactInformationTypeRepository;
        }

        public bool AddType(ContactInformationTypeWM model)
        {
            try
            {
                var result = _contactInformationTypeRepository.Create(new ContactInformationType()
                {
                    Name = model.Name
                });

                //Test
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact kayıt edilirken hata meydana geldi.");

            }           
        }
    }
}
