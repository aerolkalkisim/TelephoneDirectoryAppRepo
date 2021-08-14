using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelephoneDirectoryApp.Core.Exception.BusinessException;
using TelephoneDirectoryApp.Data.Repository;
using TelephoneDirectoryApp.Helper.Const;
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

        public List<ReportRequestWM> GetAllActiveReport() => new ReportMapping().MapToWMList(_allRepo.ReportRequestRepository.Get(x => x.IsActive == true));

        public ReportResultWM GetReportRequestResultById(Guid id)

        {
           var reportResult = _allRepo.ReportRequestRepository.GetFirst(x => x.Id == id);

            if (reportResult.Status)
            {

                //TODO: Json olarak result kolonuna basılacak ve sonuç buradan bir modelle alınacak
                return new ReportResultWM()
                {
                    Result = JsonConvert.DeserializeObject<List<ReportResultDetailWM>>(reportResult.Result),
                    StatusDescription = "Tamamlandı.",
                    Status = true
                };

            }
            else
            {
                return new ReportResultWM()
                {
                    StatusDescription = "Hazırlanıyor.",
                    Status = false
                };

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

                var factory = new ConnectionFactory() { HostName = "127.0.0.1" };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "reportQueue",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    
                    var body = Encoding.UTF8.GetBytes(result.Id.ToString());

                    channel.BasicPublish(exchange: "",
                                         routingKey: "reportQueue",
                                         basicProperties: null,
                                         body: body);

                }

                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessRuleException("Veritabanına kayıt sırasında hata oluştu.", "Contact kayıt edilirken hata meydana geldi.");
            }
        }

        public bool CalculateReportForResult(Guid id)
        {
            try
            {
                List<ReportResultDetailWM> reportResultList = new List<ReportResultDetailWM>();

                var contactInformation = _allRepo.ContactInformationRepository.GetAllActiveContactInformationWithType();
                var location = contactInformation.Where(x => x.ContactInformationType.Name == ContactTypeConst.Location).Select(x=>x.Value).Distinct().ToList();


                foreach (var item in location)
                {
                    var contactLocation = contactInformation.Where(x => x.Value == item).Select(x=>x.ContactId).Distinct().ToList();
                    var contactTelephoneNumber = contactInformation.Where(x => x.ContactInformationType.Name == ContactTypeConst.TelephoneNumber).Select(x => x.ContactId).Distinct().ToList();

                    ReportResultDetailWM reportResult = new ReportResultDetailWM()
                    {
                        Location = item,
                        ContactCount = contactInformation.Where(x => x.Value == item).Count(),
                        TelephoneNumberCount = contactLocation.Intersect(contactTelephoneNumber).Count()
                    };

                    reportResultList.Add(reportResult);
                }             

                var updatedContact = _allRepo.ReportRequestRepository.GetFirst(x => x.Id == id);
                updatedContact.Status = true;

                //ToDo result hesaplanacak
                updatedContact.Result = JsonConvert.SerializeObject(reportResultList);

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
