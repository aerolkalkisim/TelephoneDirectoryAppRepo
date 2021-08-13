using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Manager.WebManager;

namespace TelephoneDirectoryApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactManager _contactManager;


        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        public IActionResult Index()
        {
            //var addResult = _contactManager.AddContact(new Model.WebModel.ContactWM() { Name="Test", Surname="Deneme", Firm="ABC"  });
            //var updateResult = _contactManager.UpdateContact(new Model.WebModel.ContactWM() {Id= new Guid("1615e454-44ee-490b-83ab-164789754ade"), Name ="Deneme", Surname="Test", Firm="CBA"  });
            //var deleteResult = _contactManager.DeleteContact(new Guid("1615e454-44ee-490b-83ab-164789754ade"));
            //var indoAddResult = _contactManager.AddContactInformation();
            List<Model.WebModel.ContactWM> contactLsit = _contactManager.GetAllActiveContact();
            return View(contactLsit);
        }
    }
}
