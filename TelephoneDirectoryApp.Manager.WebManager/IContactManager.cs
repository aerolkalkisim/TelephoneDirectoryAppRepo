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
        bool UpdateContact(ContactWM model);
        bool DeleteContact(Guid id);


        List<ContactInformationWM> GetActiveContactInformationsByContactId(Guid ContactId);
        bool AddContactInformation(ContactInformationWM model);
        bool UpdateInformation(ContactInformationWM model);
        bool DeleteContactInformation(Guid id);

        ///Typlar sabit kaslın diye düşünüldü.
        //bool AddType(ContactInformationTypeWM model);
    }
}
