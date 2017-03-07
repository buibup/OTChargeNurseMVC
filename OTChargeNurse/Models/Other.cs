using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class Other
    {
        [ForeignKey("ChargeNurse")]
        public int OtherId { get; set; }
        public virtual OtherHarvest OtherHarvest { get; set; }
        public virtual OtherCostsExceed OtherCostsExceed { get; set; }
        public virtual OtherCostsWrong OtherCostsWrong { get; set; }

        public virtual ChargeNurse ChargeNurse { get; set; }
    }
}