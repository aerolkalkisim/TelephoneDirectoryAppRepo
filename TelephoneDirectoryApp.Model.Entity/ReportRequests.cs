using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Model.Entity
{
    public class ReportRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public DateTime RequestDate { get; set; }
        public bool Status { get; set; } = false;
        public string? Result { get; set; }
        public bool IsActive { get; set; }
    }
}
