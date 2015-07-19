using System.ComponentModel.DataAnnotations;

namespace BarCodeApplication.Models
{
    public class Import
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Ref { get; set; }      
        [MaxLength(20)]
        public string Customer { get; set; }
        [MaxLength(10)]
        public string JobNo { get; set; }
        [MaxLength(10)]
        public string ItemNo { get; set; }
        [MaxLength(10)]
        public string LabourCode { get; set; }
        [MaxLength(30)]
        public string Description { get; set; }
        [MaxLength(10)]
        public string TravellerId { get; set; }
    }
}