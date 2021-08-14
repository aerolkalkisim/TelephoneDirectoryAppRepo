using System;
using System.Collections.Generic;
using TelephoneDirectoryApp.Core.Exception.BusinessException;
using TelephoneDirectoryApp.Data.Repository;
using TelephoneDirectoryApp.Manager.Mapped;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.WebManager
{
    public class ReportManager : IReportManager
    {

        private readonly IUnitOfWork _allRepo;

        public ReportManager(IUnitOfWork allRepo)
        {
            _allRepo = allRepo;
        }

        public List<ReportRequestWM> GetAllActiveContact() => new ReportMapping().MapToWMList(_allRepo.ReportRequestRepository.Get(X => X.IsActive == true));

        public string GetReportRequestResultById(Guid id)

        {
           var reportResult = _allRepo.ReportRequestRepository.GetFirst(x => x.Id == id);

            if (reportResult.Status)
            {
                return reportResult.Result;
            }
            else
            {
                return "Rapor hazırlanıyor.";
            }

        }

        public bool AddReportRequest()
        {
            try
            {
                var result = _allRepo.ReportRequestRepository.Create(new ReportRequest
                {
                    RequestDate = DateTime.Now,
                    Status = false,
                    Result = null,
                    IsActive = true

                });

                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact kayıt edilirken hata meydana geldi.");
            }
        }

        public bool UpdateContactForResult(Guid id)
        {
            try
            {
                var updatedContact = _allRepo.ReportRequestRepository.GetFirst(x => x.Id == id);
                updatedContact.Status = true;

                //ToDo result hesaplanacak
                updatedContact.Result = "";

                var result = _allRepo.ReportRequestRepository.Update(updatedContact);
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: File logger kurulabilir. İstenmediği için şu an için düşünülmüyor. Vakit bulabilirsem ekleyeceğim.
                throw new BusinessRuleException("Veritabanına güncelleme sırasında hata oluştu.", "Contact güncellenirken beklenmeyen bir hata meydana geldi.");
            }
        }

        //SoftDelete
        public bool DeleteReportRequest(Guid id)
        {
            try
            {
                var deletedContact = _allRepo.ReportRequestRepository.GetFirst(x => x.Id == id);
                deletedContact.IsActive = false;
                var result = _allRepo.ReportRequestRepository.Update(deletedContact);
                return true;
            }
            catch (Exception ex)
            {
                //ToDo: File logger kurulabilir. İstenmediği için şu an için düşünülmüyor. Vakit bulabilirsem ekleyeceğim.
                throw new BusinessRuleException("Veritabanından silme işlemi sırasında hata oluştu.", "Contact silinirken hata meydana geldi.");
            }
        }
    }
}
