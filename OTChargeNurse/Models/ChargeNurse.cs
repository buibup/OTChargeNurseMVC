using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Models
{
    public class ChargeNurse
    {
        public ChargeNurse()
        {
            Staffings = new List<Staffing>();
        }
        [Key]
        public int ChargeNurseId { get; set; }
        public int TotalCase { get; set; }
        public virtual ICollection<Staffing> Staffings { get; set; }
        public virtual RiskCase RiskCase { get; set; }
        public virtual Other Other { get; set; }
        public string Incharge { get; set; }
        public DateTime AddDate { get; set; }

    }
}