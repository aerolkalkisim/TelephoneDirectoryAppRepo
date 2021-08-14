using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ContactInformation> GetContactInformationWithTypeByContactId(Guid ContactId)
        {
          var result = base.dataContext.ContactInformations.Include(x => x.ContactInformationType).Where(x=>x.ContactId==ContactId && x.IsActive==true).ToList();
            return result;
        }

        public List<ContactInformation> GetAllActiveContactInformationWithType()
        {
            var result = base.dataContext.ContactInformations.Include(x => x.ContactInformationType).Where(x=>x.IsActive == true).ToList();
            return result;
        }

    }
}
