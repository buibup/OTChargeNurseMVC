namespace OTChargeNurse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChargeNurses",
                c => new
                    {
                        ChargeNurseId = c.Int(nullable: false, identity: true),
                        TotalCase = c.Int(nullable: false),
                        Incharge = c.String(),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ChargeNurseId);
            
            CreateTable(
                "dbo.Other",
                c => new
                    {
                        OtherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OtherId)
                .ForeignKey("dbo.ChargeNurses", t => t.OtherId)
                .Index(t => t.OtherId);
            
            CreateTable(
                "dbo.OtherCostsExceeds",
                c => new
                    {
                        OtherCostsExceedId = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        CostExceedDocument = c.Boolean(),
                    })
                .PrimaryKey(t => t.OtherCostsExceedId)
                .ForeignKey("dbo.Other", t => t.OtherCostsExceedId)
                .Index(t => t.OtherCostsExceedId);
            
            CreateTable(
                "dbo.OtherCostsWrongs",
                c => new
                    {
                        OtherCostsWrongId = c.Int(nullable: false),
                        Flage = c.Boolean(nullable: false),
                        TotalCase = c.Int(),
                        IR = c.Boolean(),
                        IRNo = c.Int(),
                        ReportManager = c.Boolean(),
                        ReportManagerTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.OtherCostsWrongId)
                .ForeignKey("dbo.Other", t => t.OtherCostsWrongId)
                .Index(t => t.OtherCostsWrongId);
            
            CreateTable(
                "dbo.OtherHarvests",
                c => new
                    {
                        OtherHarvestId = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        Location = c.String(),
                        PutOur = c.Boolean(),
                    })
                .PrimaryKey(t => t.OtherHarvestId)
                .ForeignKey("dbo.Other", t => t.OtherHarvestId)
                .Index(t => t.OtherHarvestId);
            
            CreateTable(
                "dbo.RiskCases",
                c => new
                    {
                        RiskCaseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiskCaseId)
                .ForeignKey("dbo.ChargeNurses", t => t.RiskCaseId)
                .Index(t => t.RiskCaseId);
            
            CreateTable(
                "dbo.RiskCaseClinics",
                c => new
                    {
                        RiskCaseClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiskCaseClinicId)
                .ForeignKey("dbo.RiskCases", t => t.RiskCaseClinicId)
                .Index(t => t.RiskCaseClinicId);
            
            CreateTable(
                "dbo.RiskCaseClinicInstruments",
                c => new
                    {
                        RiskCaseClinicInstrumentId = c.Int(nullable: false),
                        Flage = c.Boolean(nullable: false),
                        Company = c.String(),
                        Ordered = c.Boolean(),
                        OrderedTime = c.DateTime(),
                        TotalCase = c.Int(),
                    })
                .PrimaryKey(t => t.RiskCaseClinicInstrumentId)
                .ForeignKey("dbo.RiskCaseClinics", t => t.RiskCaseClinicInstrumentId)
                .Index(t => t.RiskCaseClinicInstrumentId);
            
            CreateTable(
                "dbo.RiskCaseClinicSubs",
                c => new
                    {
                        RiskCaseClinicSubId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Flag = c.Boolean(nullable: false),
                        TotalCase = c.Int(),
                        QMCode5 = c.Boolean(),
                        QMCode5Time = c.DateTime(),
                        IR = c.Boolean(),
                        IRNo = c.Int(),
                        ReportSup = c.Boolean(),
                        ReportSupTime = c.DateTime(nullable: false),
                        ReportManager = c.Boolean(),
                        ReporotManagerTime = c.DateTime(),
                        RiskCaseClinicRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiskCaseClinicSubId)
                .ForeignKey("dbo.RiskCaseClinics", t => t.RiskCaseClinicRefId, cascadeDelete: true)
                .Index(t => t.RiskCaseClinicRefId);
            
            CreateTable(
                "dbo.RiskCaseServices",
                c => new
                    {
                        RiskCaseServicesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiskCaseServicesId)
                .ForeignKey("dbo.RiskCases", t => t.RiskCaseServicesId)
                .Index(t => t.RiskCaseServicesId);
            
            CreateTable(
                "dbo.RiskCaseServiceCustComplains",
                c => new
                    {
                        RiskCaseServiceCustComplainId = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        TotalCase = c.Int(),
                        IR = c.Boolean(),
                        IRNo = c.Int(),
                        ReportSup = c.Boolean(),
                    })
                .PrimaryKey(t => t.RiskCaseServiceCustComplainId)
                .ForeignKey("dbo.RiskCaseServices", t => t.RiskCaseServiceCustComplainId)
                .Index(t => t.RiskCaseServiceCustComplainId);
            
            CreateTable(
                "dbo.RiskCaseServiceVIPs",
                c => new
                    {
                        RiskCaseServiceVIPId = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        TotalCase = c.Int(),
                    })
                .PrimaryKey(t => t.RiskCaseServiceVIPId)
                .ForeignKey("dbo.RiskCaseServices", t => t.RiskCaseServiceVIPId)
                .Index(t => t.RiskCaseServiceVIPId);
            
            CreateTable(
                "dbo.Staffings",
                c => new
                    {
                        StaffingId = c.Int(nullable: false, identity: true),
                        Period = c.String(),
                        InAdequet = c.Boolean(),
                        Help = c.Boolean(),
                        ChargeNurseRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StaffingId)
                .ForeignKey("dbo.ChargeNurses", t => t.ChargeNurseRefId, cascadeDelete: true)
                .Index(t => t.ChargeNurseRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffings", "ChargeNurseRefId", "dbo.ChargeNurses");
            DropForeignKey("dbo.RiskCaseServiceVIPs", "RiskCaseServiceVIPId", "dbo.RiskCaseServices");
            DropForeignKey("dbo.RiskCaseServiceCustComplains", "RiskCaseServiceCustComplainId", "dbo.RiskCaseServices");
            DropForeignKey("dbo.RiskCaseServices", "RiskCaseServicesId", "dbo.RiskCases");
            DropForeignKey("dbo.RiskCaseClinicSubs", "RiskCaseClinicRefId", "dbo.RiskCaseClinics");
            DropForeignKey("dbo.RiskCaseClinics", "RiskCaseClinicId", "dbo.RiskCases");
            DropForeignKey("dbo.RiskCaseClinicInstruments", "RiskCaseClinicInstrumentId", "dbo.RiskCaseClinics");
            DropForeignKey("dbo.RiskCases", "RiskCaseId", "dbo.ChargeNurses");
            DropForeignKey("dbo.OtherHarvests", "OtherHarvestId", "dbo.Other");
            DropForeignKey("dbo.OtherCostsWrongs", "OtherCostsWrongId", "dbo.Other");
            DropForeignKey("dbo.OtherCostsExceeds", "OtherCostsExceedId", "dbo.Other");
            DropForeignKey("dbo.Other", "OtherId", "dbo.ChargeNurses");
            DropIndex("dbo.Staffings", new[] { "ChargeNurseRefId" });
            DropIndex("dbo.RiskCaseServiceVIPs", new[] { "RiskCaseServiceVIPId" });
            DropIndex("dbo.RiskCaseServiceCustComplains", new[] { "RiskCaseServiceCustComplainId" });
            DropIndex("dbo.RiskCaseServices", new[] { "RiskCaseServicesId" });
            DropIndex("dbo.RiskCaseClinicSubs", new[] { "RiskCaseClinicRefId" });
            DropIndex("dbo.RiskCaseClinicInstruments", new[] { "RiskCaseClinicInstrumentId" });
            DropIndex("dbo.RiskCaseClinics", new[] { "RiskCaseClinicId" });
            DropIndex("dbo.RiskCases", new[] { "RiskCaseId" });
            DropIndex("dbo.OtherHarvests", new[] { "OtherHarvestId" });
            DropIndex("dbo.OtherCostsWrongs", new[] { "OtherCostsWrongId" });
            DropIndex("dbo.OtherCostsExceeds", new[] { "OtherCostsExceedId" });
            DropIndex("dbo.Other", new[] { "OtherId" });
            DropTable("dbo.Staffings");
            DropTable("dbo.RiskCaseServiceVIPs");
            DropTable("dbo.RiskCaseServiceCustComplains");
            DropTable("dbo.RiskCaseServices");
            DropTable("dbo.RiskCaseClinicSubs");
            DropTable("dbo.RiskCaseClinicInstruments");
            DropTable("dbo.RiskCaseClinics");
            DropTable("dbo.RiskCases");
            DropTable("dbo.OtherHarvests");
            DropTable("dbo.OtherCostsWrongs");
            DropTable("dbo.OtherCostsExceeds");
            DropTable("dbo.Other");
            DropTable("dbo.ChargeNurses");
        }
    }
}
