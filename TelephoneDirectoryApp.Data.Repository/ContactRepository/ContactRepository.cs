using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectoryApp.Core.Data.BaseRepository;
using TelephoneDirectoryApp.Data.DataContext;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.Repository
{
    public class ContactRepository : EntityRepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(ProjectDbContext context) : base(context)
        {

        }
    }
}
