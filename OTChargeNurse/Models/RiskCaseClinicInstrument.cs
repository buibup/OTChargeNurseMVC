using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseClinicInstrument
    {
        [ForeignKey("RiskCaseClinic")]
        public int RiskCaseClinicInstrumentId { get; set; }
        public bool Flage { get; set; }
        public string Company { get; set; }
        public bool? Ordered { get; set; }
        public DateTime? OrderedTime { get; set; }
        public int? TotalCase { get; set; }

        public virtual RiskCaseClinic RiskCaseClinic { get; set; }
    }
}