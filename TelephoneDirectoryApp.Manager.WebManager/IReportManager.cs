using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.WebManager
{
    public interface IReportManager
    {
        List<ReportRequestWM> GetAllActiveReport();
        ReportResultWM GetReportRequestResultById(Guid id);
        bool AddReportRequest();
        bool CalculateReportForResult(Guid id);
        bool DeleteReportRequest(Guid id);
    }
}
