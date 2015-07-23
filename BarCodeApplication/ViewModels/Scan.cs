using System.ComponentModel.DataAnnotations;

namespace BarCodeApplication.ViewModels
{
    public class Scan
    {   [MaxLength(15)]
        public string BarCode { get; set; } 

        [MaxLength(15)]
        public string EndConfirmation { get; set; }
    }
}