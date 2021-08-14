using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Manager.WebManager;

namespace TelephoneDirectoryApp.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportManager _reportManager;


        public ReportController(IReportManager reportManager)
        {
            _reportManager = reportManager;
        }

        //Sil, Sonuç görüntüle yaptırılacak.

        public IActionResult Index()
        {
            //TestQueue
            // _reportManager.CalculateReportForResult(new Guid("b63a1f0b-8bd6-4caf-83f9-3e2916568e09"));

            List<Model.WebModel.ReportRequestWM> reportRequestList = _reportManager.GetAllActiveReport();
            return View(reportRequestList);
        }

        //Auth olayları ile güvenlik sağlanmalı. Vakit yok.
        [HttpPost]
        public JsonResult CreateReportRequest()
        {
            return new JsonResult(_reportManager.AddReportRequest());
        }

        [HttpPost]
        public JsonResult DeleteReportRequest(Guid ReportId)
        {
            return new JsonResult(_reportManager.DeleteReportRequest(ReportId));
        }

        [HttpGet]
        public JsonResult GetReportDetail(Guid ReportId)
        {
            return new JsonResult(_reportManager.GetReportRequestResultById(ReportId));
        }

    }
}
