using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class OtherHarvest
    {
        [ForeignKey("Other")]
        public int OtherHarvestId { get; set; }
        public bool Flag { get; set; }
        public string Location { get; set; }
        public bool? PutOur { get; set; }

        public virtual Other Other { get; set; }
    }
}