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
        private static StartPieceViewModel viewModel;
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(StartPieceViewModel vm)
        {

            var ctx = new BarCodeContext();

            if (vm.FinishPiece == "yes")
            {
                var job = new Job
                {
                    Status = "started",
                    Start = DateTime.Now,
                    End = new DateTime(1900, 01, 01, 00, 00, 00),
                    PieceNo = vm.PieceNo
                };
                ctx.Job.Add(job);
                ctx.SaveChanges();

                vm = viewModel;
                return View("JobFinish", vm);
            }

            else
            {
                //var result = ctx.Job.First(a => a.TravellerId == scan.BarCode);
                var result = ctx.Import.First(a => a.PieceNo == vm.PieceNo);
                vm.Id = result.Id;
                vm.Project = result.Project;
                vm.CompanyName = result.CompanyName;
                vm.Description = result.Description;
                vm.JobNo = result.JobNo;

                viewModel = vm;
                return View("StartPiece", vm);


            }


        }


    }

}
