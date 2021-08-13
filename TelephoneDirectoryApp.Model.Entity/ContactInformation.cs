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
        public Guid ContactId { get; set; }
        public Guid TypeId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ContactInformationType Type { get; set; }


    }
}
