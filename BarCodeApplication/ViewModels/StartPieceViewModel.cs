using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarCodeApplication.ViewModels
{
    public class StartPieceViewModel
    {
        public int Id { get; set; }
        public string PieceNo { get; set; }
        public string JobNo { get; set; }
        public string CompanyName  { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string FinishPiece { get; set; }

    }
}