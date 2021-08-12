using System;
using System.Collections.Generic;
using TelephoneDirectoryApp.Core.Exception.BusinessException;
using TelephoneDirectoryApp.Data.Repository;
using TelephoneDirectoryApp.Manager.Mapped;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.WebManager
{
    public class ContactManager : IContactManager
    {
        //private readonly IContactInformationTypeRepository _contactInformationTypeRepository;

        //public ContactInformationTypeManager(IContactInformationTypeRepository contactInformationTypeRepository)
        //{
        //    _contactInformationTypeRepository = contactInformationTypeRepository;
        //}

        private readonly IUnitOfWork _allRepo;

        public ContactManager(IUnitOfWork allRepo)
        {
            _allRepo = allRepo;
        }

        #region Contact

        public List<ContactWM> GetAllActiveContact() => new ContactMapping().MapToWMList(_allRepo.ContactRepository.Get(X=>X.IsActive==true));


        public bool AddContact(ContactWM model)
        {
            try
            {
                var result = _allRepo.ContactRepository.Create(new ContactMapping().MapToEntitiy(model));
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact kayıt edilirken hata meydana geldi.");

            }
        }

        public void UpdateContact()
        {

        }

        public void DeleteContact()
        {

        }


        #endregion



        #region Type

        public bool AddType(ContactInformationTypeWM model)
        {
            try
            {
                var result = _allRepo.ContactInformationTypeRepository.Create(new ContactInformationType()
                {
                    Name = model.Name
                });

                //var result = _contactInformationTypeRepository.Create(new ContactInformationType()
                //{
                //    Name = model.Name
                //});

                //Test
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact Information Type kayıt edilirken hata meydana geldi.");

            }           
        }

        #endregion
    }
}
