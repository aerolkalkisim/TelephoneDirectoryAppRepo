using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectoryApp.Model.WebModel
{
    public class ReportResultWM
    {
        public bool Status { get; set; }
        public string StatusDescription { get; set; }

        public List<ReportResultDetailWM> Result { get; set; }
    }

       public class ReportResultDetailWM
    {
        public string Location { get; set; }
        public int ContactCount { get; set; }
        public int TelephoneNumberCount { get; set; }
    }
}
