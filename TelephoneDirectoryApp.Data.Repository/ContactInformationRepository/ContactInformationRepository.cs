using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectoryApp.Core.Data.BaseRepository;
using TelephoneDirectoryApp.Data.DataContext;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.Repository
{
    public class ContactInformationRepository : EntityRepositoryBase<ContactInformation>, IContactInformationRepository
    {
        public ContactInformationRepository(ProjectDbContext context) : base(context)
        {
                
        }
    }
}
