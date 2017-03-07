using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseServiceCustComplain
    {
        [ForeignKey("RiskCaseServices")]
        public int RiskCaseServiceCustComplainId { get; set; }
        public bool Flag { get; set; }
        public int? TotalCase { get; set; }
        public bool? IR { get; set; }
        public int? IRNo { get; set; }
        public bool? ReportSup { get; set; }

        public virtual RiskCaseServices RiskCaseServices { get; set; }
    }
}