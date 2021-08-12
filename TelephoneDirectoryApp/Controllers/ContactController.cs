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
            //var addResult = _contactManager.AddContact(new Model.WebModel.ContactWM() { Name="Kazım", Surname="Koyuncu", Firm="ABC"  });
            List<Model.WebModel.ContactWM> contactLsit = _contactManager.GetAllActiveContact();
            return View(contactLsit);
        }
    }
}
