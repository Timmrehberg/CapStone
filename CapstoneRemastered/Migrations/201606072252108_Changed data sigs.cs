namespace CapstoneRemastered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changeddatasigs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours2", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours2", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours3", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours3", c => c.String());
            AlterColumn("dbo.HourBreakdowns", "TotalHours", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HourBreakdowns", "TotalHours", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours3", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours3", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours2", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours2", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OffDutyHours", c => c.Int(nullable: false));
            AlterColumn("dbo.HourBreakdowns", "OnDutyHours", c => c.Int(nullable: false));
        }
    }
}
