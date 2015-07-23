using System.ComponentModel.DataAnnotations;

namespace BarCodeApplication.Models
{
    public class Import
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Ref { get; set; }      
        [MaxLength(30)]
        public string Customer { get; set; }
        [MaxLength(15)]
        public string JobNo { get; set; }
        [MaxLength(15)]
        public string ItemNo { get; set; }
        [MaxLength(15)]
        public string PieceNo { get; set; }
        [MaxLength(15)]
        public string LabourCode { get; set; }
        [MaxLength(40)]
        public string Description { get; set; }
        [MaxLength(40)]
        public string Project { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
    }
}