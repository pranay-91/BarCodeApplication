using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarCodeApplication.DAL;
using BarCodeApplication.Models;
using BarCodeApplication.ViewModels;

namespace BarCodeApplication.Controllers
{
    public class ScanController : Controller
    {
        
        public ActionResult Index()
        {
            using (var ctx = new BarCodeContext())
            {

                Job j = new Job{TravellerId="1001", Status = "Started", Start = new DateTime(1991,12,09), End = new DateTime(1993,1,20)};
                ctx.Job.Add(j);
                ctx.SaveChanges();

            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(Scan scan)
        {
            using (var ctx = new BarCodeContext())
            {

            }
            return View("Scan",scan);
        }
    }
}
