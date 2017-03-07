using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class RiskCaseClinic
    {
        public RiskCaseClinic()
        {
            RiskCaseClinicSub = new List<RiskCaseClinicSub>();
        }
        [ForeignKey("RiskCase")]
        public int RiskCaseClinicId { get; set; }
        public virtual ICollection<RiskCaseClinicSub> RiskCaseClinicSub { get; set; }
        public virtual RiskCaseClinicInstrument Instrument { get; set; }

        public virtual RiskCase RiskCase { get; set; }
    }
}