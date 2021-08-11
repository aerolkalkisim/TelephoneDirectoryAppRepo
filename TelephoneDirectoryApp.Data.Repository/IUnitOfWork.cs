using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IContactInformationTypeRepository ContactInformationTypeRepository { get; }
        //Task<int> CommitAsync();
    }
}
