using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Core.Data.BaseRepository;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.Repository
{
    public interface IReportRequestRepository : IEntityRepository<ReportRequest>
    {
    }
}
