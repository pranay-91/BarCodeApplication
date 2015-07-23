using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarCodeApplication.Models;
using System.Data.OleDb;
using BarCodeApplication.DAL;
using BarCodeApplication.ViewModels;

namespace BarCodeApplication.Controllers
{
    public class ImportController : Controller
    {
        // GET: ImportJob
      
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ImportSettings i)
        {

            BarCodeContext db = new BarCodeContext();
            
            Import newImport = new Import();

            if (Request.Files["FileUpload"].ContentLength > 0)
            {

                string extension = System.IO.Path.GetExtension(Request.Files["FileUpload"].FileName);
                string path = string.Format("{0}/{1}", Server.MapPath("~/Content/UploadedFolder"),Request.Files["FileUpload"].FileName);
                    
                //ImportSettings newImportSettings = new ImportSettings(path, extension);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);

                Request.Files["FileUpload"].SaveAs(path);
                //string sqlConnectionString = @"Data Source=PRONOY-XPS\XPSSERVER; Database=Import; Trusted_Connection=true;Persist Security Info=True";


                //Create connection string to Excel work book
                string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path +
                                               ";Extended Properties=Excel 12.0;Persist Security Info=False";
                //Create Connection to Excel work book
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                //Create OleDbCommand to fetch data from Excel
                OleDbCommand cmd =
                    new OleDbCommand(
                        "Select [Ref],[Customer],[Job No],[Item No], [Labour Code], [Description], [Project], [Company Name] from [Sheet1$]",
                        excelConnection);
                excelConnection.Open();
                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();

                while (dReader.Read())
                {
                    newImport.Ref = (string) dReader["Ref"].ToString();
                    newImport.Customer = (string) dReader["Customer"].ToString();
                    newImport.JobNo = (string) dReader["Job No"].ToString();
                    newImport.ItemNo = (string) dReader["Item No"].ToString();
                    newImport.PieceNo = newImport.JobNo + '-' + newImport.ItemNo;
                    newImport.LabourCode = (string) dReader["Labour Code"].ToString();
                    newImport.Description = (string) dReader["Description"].ToString();
                    newImport.Project = (string) dReader["Project"].ToString();
                    newImport.CompanyName = (string) dReader["Company Name"].ToString();

                    if (ModelState.IsValid)
                    {

                        db.Import.Add(newImport);
                        db.SaveChanges();
                    }

                }


                //   SqlBulkCopy sqlBulk = new SqlBulkCopy(sqlConnectionString);
                //Give your Destination table name
                // sqlBulk.DestinationTableName = "tblStudents";
                //sqlBulk.WriteToServer(dReader);
                excelConnection.Close();
                // SQL Server Connection String

            }
            return RedirectToAction("Index");
        }
    }
}