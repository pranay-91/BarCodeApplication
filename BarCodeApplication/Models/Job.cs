using System;
using System.ComponentModel.DataAnnotations;

namespace BarCodeApplication.Models
{
    public class Job
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string TravellerId { get; set; }
        [MaxLength(30)]
        public string PieceNo { get; set; }
        [MaxLength(12)]
        public string Status { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

     }
}