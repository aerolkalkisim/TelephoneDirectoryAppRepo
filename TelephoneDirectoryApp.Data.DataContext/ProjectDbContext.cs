using Microsoft.EntityFrameworkCore;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.DataContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<ContactInformationType> ContactInformationType { get; set; }
    }
}

