using System;
using System.Collections.Generic;
using System.Linq;
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
        public ContactWM GetContactById(Guid id) => new ContactMapping().MapToWM(_allRepo.ContactRepository.GetFirst(X=>X.Id== id));


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

        public bool UpdateContact(ContactWM model)
        {
            try
            {
                var result = _allRepo.ContactRepository.Update(new ContactMapping().MapToEntitiy(model));
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: File logger kurulabilir. İstenmediği için şu an için düşünülmüyor. Vakit bulabilirsem ekleyeceğim.
                throw new BusinessRuleException("Veritabanına güncelleme sırasında hata oluştu.", "Contact güncellenirken beklenmeyen bir hata meydana geldi.");
            }
        }

        //SoftDelete
        public bool DeleteContact(Guid id)
        {
            try
            {
                var deletedContact = _allRepo.ContactRepository.GetFirst(x=>x.Id==id);
                deletedContact.IsActive = false;
                var result = _allRepo.ContactRepository.Update(deletedContact);
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: File logger kurulabilir. İstenmediği için şu an için düşünülmüyor. Vakit bulabilirsem ekleyeceğim.
                throw new BusinessRuleException("Veritabanından silme işlemi sırasında hata oluştu.", "Contact silinirken hata meydana geldi.");
            }
        }

        #endregion

        #region ContactInformation

        //ToDo: Detay getir ve detay ekle sil güncelle metotları eklenecek.


        public List<ContactInformationWM> GetActiveContactInformationsByContactId(Guid ContactId) => new ContactMapping().MapToWMListForInformation(_allRepo.ContactInformationRepository.GetContactInformationWithTypeByContactId(ContactId));
        public ContactInformationWM GetContactInformationsByContactInfoId(Guid ContactInfoId) => new ContactMapping().MapToWMLForInformation(_allRepo.ContactInformationRepository.GetFirst(x=>x.Id==ContactInfoId));

        public bool AddContactInformation(ContactInformationWM model)
        {
            try
            {
                var result = _allRepo.ContactInformationRepository.Create(new ContactMapping().MapToEnttiyForInformation(model));
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact Information kayıt edilirken hata meydana geldi.");

            }
        }


        public bool UpdateInformation(ContactInformationWM model)
        {
            try
            {
                var updatedContact = _allRepo.ContactInformationRepository.GetFirst(x => x.Id == model.Id);
                updatedContact.TypeId = model.TypeId;
                updatedContact.Value = model.Value;

                //var result = _allRepo.ContactInformationRepository.Update(new ContactMapping().MapToEnttiyForInformation(model));
                var result = _allRepo.ContactInformationRepository.Update(updatedContact);
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: logger
                throw new BusinessRuleException("Veritabanına güncelleme sırasında hata oluştu.", "Contact Information güncellenirken beklenmeyen bir hata meydana geldi.");
            }
        }


        //SoftDelete
        public bool DeleteContactInformation(Guid id)
        {
            try
            {
                var deletedContact = _allRepo.ContactInformationRepository.GetFirst(x => x.Id == id);
                deletedContact.IsActive = false;
                var result = _allRepo.ContactInformationRepository.Update(deletedContact);
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: logger
                throw new BusinessRuleException("Veritabanından silme işlemi sırasında hata oluştu.", "Contact Information silinirken hata meydana geldi.");
            }
        }

        #endregion


        #region Type

        public List<ContactInformationTypeWM> GetAllActiveContactInfoType() {

            return _allRepo.ContactInformationTypeRepository.Get().Select(x => new ContactInformationTypeWM
            {
                Id = x.Id,
                Name = x.Name,

            }).ToList();

        } 


        public bool AddType(ContactInformationTypeWM model)
        {
            try
            {
                var result = _allRepo.ContactInformationTypeRepository.Create(new ContactInformationType()
                {
                    Name = model.Name
                });

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
