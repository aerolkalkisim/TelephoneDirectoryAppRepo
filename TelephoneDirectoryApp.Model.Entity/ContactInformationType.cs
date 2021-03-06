using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TelephoneDirectoryApp.Model.Entity
{
    public class ContactInformationType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }      
        public ICollection<ContactInformationType> ContactInformationTypes { get; set; }
    }
}
