namespace CapstoneRemastered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mADEVIEWS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyLogMileageAndFuelReports",
                c => new
                    {
                        Driver = c.String(nullable: false, maxLength: 128),
                        DateofWork = c.String(),
                        Owner = c.String(),
                        Tractornumber = c.Int(nullable: false),
                        Trailernumber = c.Int(nullable: false),
                        Pronumber = c.Int(nullable: false),
                        State = c.String(),
                        Totalmilesdriven = c.Int(nullable: false),
                        Totalgaspurchased = c.Double(nullable: false),
                        Routestraveled = c.String(),
                        Odometerstart = c.Int(nullable: false),
                        Odometerfinish = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Driver);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DailyLogMileageAndFuelReports");
        }
    }
}
