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
        private ContactRepository _contactRepository;
        private ContactInformationRepository _contactInformationRepository;
        private ContactInformationTypeRepository _contactInformationTypeRepository;

        public UnitOfWork(ProjectDbContext context)
        {
            this._context = context;
        }

        public IContactRepository ContactRepository => _contactRepository = _contactRepository ?? new ContactRepository(_context);
        public IContactInformationRepository ContactInformationRepository => _contactInformationRepository = _contactInformationRepository ?? new ContactInformationRepository(_context);
        public IContactInformationTypeRepository ContactInformationTypeRepository => _contactInformationTypeRepository = _contactInformationTypeRepository ?? new ContactInformationTypeRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
