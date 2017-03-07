using OTChargeNurse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OTChargeNurse.Context
{
    public class ChargeNurseContext : DbContext
    {
        public ChargeNurseContext() : base("ChargeNurseContext")
        {

        }

        public DbSet<ChargeNurse> ChargeNurses { get; set; }

        public System.Data.Entity.DbSet<OTChargeNurse.Models.Other> Other { get; set; }

        public System.Data.Entity.DbSet<OTChargeNurse.Models.RiskCase> RiskCases { get; set; }
    }
}