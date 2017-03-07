using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCase
    {
        [ForeignKey("ChargeNurse")]
        public int RiskCaseId { get; set; }
        public virtual RiskCaseClinic RiskCaseClinic { get; set; }
        public virtual RiskCaseServices RiskCaseServices { get; set; }

        public virtual ChargeNurse ChargeNurse { get; set; }
    }
}