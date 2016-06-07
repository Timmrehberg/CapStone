namespace CapstoneRemastered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTablesForLogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HourBreakdowns",
                c => new
                    {
                        Hoursworked = c.Int(nullable: false, identity: true),
                        VehicleNumbers = c.String(),
                        Signature = c.String(),
                        CoDriver = c.String(),
                        OnDutyHours = c.Int(nullable: false),
                        OffDutyHours = c.Int(nullable: false),
                        OnDutyHours2 = c.Int(nullable: false),
                        OffDutyHours2 = c.Int(nullable: false),
                        OnDutyHours3 = c.Int(nullable: false),
                        OffDutyHours3 = c.Int(nullable: false),
                        TotalHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Hoursworked);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HourBreakdowns");
        }
    }
}
