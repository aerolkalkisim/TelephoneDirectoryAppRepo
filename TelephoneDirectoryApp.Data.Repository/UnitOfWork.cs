using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Data.DataContext;

namespace TelephoneDirectoryApp.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ProjectDbContext _context;
        private ContactInformationTypeRepository _contactInformationTypeRepository;

        public UnitOfWork(ProjectDbContext context)
        {
            this._context = context;
        }

        public IContactInformationTypeRepository ContactInformationTypeRepository => _contactInformationTypeRepository = _contactInformationTypeRepository ?? new ContactInformationTypeRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
