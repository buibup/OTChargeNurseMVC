using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseServiceVIP
    {
        [ForeignKey("RiskCaseServices")]
        public int RiskCaseServiceVIPId { get; set; }
        public bool Flag { get; set; }
        public int? TotalCase { get; set; }

        public virtual RiskCaseServices RiskCaseServices { get; set; }
    }
}