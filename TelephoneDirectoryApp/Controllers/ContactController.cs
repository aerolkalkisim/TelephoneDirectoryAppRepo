using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Manager.WebManager;
using TelephoneDirectoryApp.Model.WebModel;

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

        //public class CrudResult
        //{
        //    public bool status { get; set; }
        //    public string Message { get; set; }
        //}

        [HttpPost]
        public JsonResult AddContact(ContactWM model)
        {

            if(string.IsNullOrEmpty(model.Name)|| string.IsNullOrEmpty(model.Surname))
            {
                return new JsonResult(false);
            }

            return new JsonResult(_contactManager.AddContact(model));
        }

        [HttpGet]
        public JsonResult GetContactById(string ContactId)
        {
            return new JsonResult(_contactManager.GetContactById(new Guid(ContactId)));
        }

        [HttpPost]
        public JsonResult UpdateContact(ContactWM model)
        {

            if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Surname))
            {
                return new JsonResult(false);
            }

            return new JsonResult(_contactManager.UpdateContact(model));
        }


        [HttpPost]
        public JsonResult DeleteContact(string ContactId)
        {
            return new JsonResult(_contactManager.DeleteContact(new Guid(ContactId)));
        }





        [HttpGet]
        public JsonResult GetAllContactType()
        {
            return new JsonResult(_contactManager.GetAllActiveContactInfoType());
        }

        [HttpPost]
        public JsonResult AddContactInformation(ContactInformationWM model)
        {

            if (string.IsNullOrEmpty(model.TypeId.ToString()) || string.IsNullOrEmpty(model.Value))
            {
                return new JsonResult(false);
            }

            return new JsonResult(_contactManager.AddContactInformation(model));
        }

        [HttpGet]
        public JsonResult GetContactInformationByContactId(string ContactId)
        {
            return new JsonResult(_contactManager.GetActiveContactInformationsByContactId(new Guid(ContactId)));
        }
    }
}
