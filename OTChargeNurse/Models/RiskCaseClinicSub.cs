using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseClinicSub
    {
        public int RiskCaseClinicSubId { get; set; }
        public string Name { get; set; }
        public bool Flag { get; set; }
        public int? TotalCase { get; set; }
        public bool? QMCode5 { get; set; }
        public DateTime? QMCode5Time { get; set; }
        public bool? IR { get; set; }
        public int? IRNo { get; set; }
        public bool? ReportSup { get; set; }
        public DateTime ReportSupTime { get; set; }
        public bool? ReportManager { get; set; }
        public DateTime? ReporotManagerTime { get; set; }

        public int RiskCaseClinicRefId { get; set; }
        [ForeignKey("RiskCaseClinicRefId")]
        public virtual RiskCaseClinic RiskCaseClinic { get; set; }
    }
}