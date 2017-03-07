using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class OtherCostsWrong
    {
        [ForeignKey("Other")]
        public int OtherCostsWrongId { get; set; }
        public bool Flage { get; set; }
        public int? TotalCase { get; set; }
        public bool? IR { get; set; }
        public int? IRNo { get; set; }
        public bool? ReportManager { get; set; }
        public DateTime? ReportManagerTime { get; set; }

        public virtual Other Other { get; set; }
    }
}