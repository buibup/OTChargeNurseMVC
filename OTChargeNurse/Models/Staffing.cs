using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class Staffing
    {
        public int StaffingId { get; set; }
        public string Period { get; set; }
        public bool? InAdequet { get; set; }
        public bool? Help { get; set; }

        public int ChargeNurseRefId { get; set; }

        [ForeignKey("ChargeNurseRefId")]
        public virtual ChargeNurse ChargeNurse { get; set; }
    }
}