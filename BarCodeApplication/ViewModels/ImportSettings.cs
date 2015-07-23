using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BarCodeApplication.ViewModels
{
    public class ImportSettings
    {
       public string Location { get; set; }
        public string Filename { get; set; }


        public ImportSettings()
        {
        }

        public ImportSettings(string newLocation, string newFilename)
        {
          
            Location = newLocation;
            Filename = newFilename;
        }
    }
}