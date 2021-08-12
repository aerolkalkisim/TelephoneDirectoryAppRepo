using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository ContactRepository { get; }
        IContactInformationRepository ContactInformationRepository { get; }
        IContactInformationTypeRepository ContactInformationTypeRepository { get; }

        //Task<int> CommitAsync();
    }
}
