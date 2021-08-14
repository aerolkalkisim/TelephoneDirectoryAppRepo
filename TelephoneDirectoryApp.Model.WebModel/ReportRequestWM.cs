using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectoryApp.Model.WebModel
{
    public class ReportRequestWM
    {
        public Guid Id { get; set; }
        public DateTime RequestDate { get; set; }
        public bool Status { get; set; } = false;
        public DateTime StatusChangeDate { get; set; }
        public string? Result { get; set; }
        public bool IsActive { get; set; }
    }
}
