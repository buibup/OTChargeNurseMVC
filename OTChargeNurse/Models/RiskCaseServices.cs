using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseServices
    {
        [ForeignKey("RiskCase")]
        public int RiskCaseServicesId { get; set; }
        public virtual RiskCaseServiceVIP RiskCaseServiceVIP { get; set; }
        public virtual RiskCaseServiceCustComplain RiskCaseServiceCustComplain { get; set; }

        public virtual RiskCase RiskCase { get; set; }
    }
}