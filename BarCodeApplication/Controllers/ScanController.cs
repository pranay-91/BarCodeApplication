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
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(Scan scan)
        {

            var ctx = new BarCodeContext();

            //var result = ctx.Job.First(a => a.TravellerId == scan.BarCode);
            var result = ctx.Import.First(a => a.JobNo == scan.BarCode);

            return View("Scan", (Import)result);
            
       

           
        }
    }
}
