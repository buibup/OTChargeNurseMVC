using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class OtherCostsExceed
    {
        [ForeignKey("Other")]
        public int OtherCostsExceedId { get; set; }
        public bool Flag { get; set; }
        public bool? CostExceedDocument { get; set; }

        public virtual Other Other { get; set; }
    }
}