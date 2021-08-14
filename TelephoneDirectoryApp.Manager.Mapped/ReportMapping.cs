using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Model.Entity;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.Mapped
{
    public class ReportMapping
    {
        public List<ReportRequestWM> MapToWMList(List<ReportRequest> modelEntity)
        {
            return modelEntity.Select(x => new ReportRequestWM
            {
                Id= x.Id,
                IsActive=x.IsActive,
                RequestDate=x.RequestDate,
                Result=x.Result,
                Status=x.Status

            }).ToList();
        }

        public ReportRequest MapToEntitiyForAdd(ReportRequestWM modelWM)
        {
            return new ReportRequest
            {
                Id = modelWM.Id,
                RequestDate=DateTime.Now,
                Status=false,
                Result=null,     
                IsActive = true

            };
        }
    }
}
