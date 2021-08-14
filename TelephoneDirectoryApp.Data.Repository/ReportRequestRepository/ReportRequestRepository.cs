using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Core.Data.BaseRepository;
using TelephoneDirectoryApp.Data.DataContext;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.Repository
{

    public class ReportRequestRepository : EntityRepositoryBase<ReportRequest>, IReportRequestRepository
    {
        public ReportRequestRepository(ProjectDbContext context) : base(context)
        {

        }
    }
}
