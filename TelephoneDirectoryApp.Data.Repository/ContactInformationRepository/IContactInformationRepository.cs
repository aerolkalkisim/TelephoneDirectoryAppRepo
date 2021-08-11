using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectoryApp.Core.Data.BaseRepository;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.Repository
{
    public interface IContactInformationRepository : IEntityRepository<ContactInformation>
    {
    }
}
