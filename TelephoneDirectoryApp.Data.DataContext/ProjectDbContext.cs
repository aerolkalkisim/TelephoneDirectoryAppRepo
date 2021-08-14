using Microsoft.EntityFrameworkCore;
using System;
using TelephoneDirectoryApp.Helper.Const;
using TelephoneDirectoryApp.Model.Entity;

namespace TelephoneDirectoryApp.Data.DataContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<ContactInformationType> ContactInformationType { get; set; }
        public DbSet<ReportRequest> ReportRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here 
            //Department
            modelBuilder.Entity<ContactInformationType>()
                        .HasData(
                         new ContactInformationType { Id = Guid.NewGuid(), Name = ContactTypeConst.TelephoneNumber },
                         new ContactInformationType { Id = Guid.NewGuid(), Name = ContactTypeConst.HomeTelephoneNumber },
                         new ContactInformationType { Id = Guid.NewGuid(), Name = ContactTypeConst.BusinessTelephoneNumber },
                         new ContactInformationType { Id = Guid.NewGuid(), Name = ContactTypeConst.Email },
                         new ContactInformationType { Id = Guid.NewGuid(), Name = ContactTypeConst.Konum }
                         );
        }
    }
}

