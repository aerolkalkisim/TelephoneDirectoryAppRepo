using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Model.WebModel;

namespace TelephoneDirectoryApp.Manager.WebManager
{
    public interface IContactManager
    {
        List<ContactWM> GetAllActiveContact();

        bool AddContact(ContactWM model);

        bool AddType(ContactInformationTypeWM model);
    }
}
