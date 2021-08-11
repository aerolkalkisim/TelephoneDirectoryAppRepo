using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TelephoneDirectoryApp.Model.Entity
{
    public class ContactInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public ContactInformationType Type { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
