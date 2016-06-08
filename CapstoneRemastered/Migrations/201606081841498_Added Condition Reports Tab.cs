namespace CapstoneRemastered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConditionReportsTab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VehicleConditionReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        brakeLinesToTrailerPre = c.String(),
                        brakeLinesToTrailerPost = c.String(),
                        electricLinesToTrailerPre = c.String(),
                        electricLinesToTrailerPost = c.String(),
                        driveLinePre = c.String(),
                        driveLinePost = c.String(),
                        couplingDevicePre = c.String(),
                        couplingDevicePost = c.String(),
                        tiresandWheelsPre = c.String(),
                        tiresandWheelsPost = c.String(),
                        springsPre = c.String(),
                        springsPost = c.String(),
                        bodyPre = c.String(),
                        bodyPost = c.String(),
                        glassPre = c.String(),
                        glassPost = c.String(),
                        torchesAndReflectorsAndLanternsPre = c.String(),
                        torchesAndReflectorsAndLanternsPost = c.String(),
                        fusersPre = c.String(),
                        fusersPost = c.String(),
                        flagsPre = c.String(),
                        flagsPost = c.String(),
                        spareBulbsPre = c.String(),
                        spareBulbsPost = c.String(),
                        fusesPre = c.String(),
                        fusesPost = c.String(),
                        fireExtinquisherPre = c.String(),
                        fireExtinquisherPost = c.String(),
                        tireChainsPre = c.String(),
                        tireChainsPost = c.String(),
                        afterStartingEnginePre = c.String(),
                        afterStartingEnginePost = c.String(),
                        fuelSystemPre = c.String(),
                        fuelSystemPost = c.String(),
                        coolingSystemPre = c.String(),
                        coolingSystemPost = c.String(),
                        enginePre = c.String(),
                        enginePost = c.String(),
                        leaksPre = c.String(),
                        leaksPost = c.String(),
                        lightsPre = c.String(),
                        lightsPost = c.String(),
                        tailPre = c.String(),
                        tailPost = c.String(),
                        stopAndTurnPre = c.String(),
                        stopAndTurnPost = c.String(),
                        clearanceAndMarkerPre = c.String(),
                        clearanceAndMarkerPost = c.String(),
                        reflectorsPre = c.String(),
                        reflectorsPost = c.String(),
                        airPressureWarningDevicePre = c.String(),
                        airPressureWarningDevicePost = c.String(),
                        oilPressurePre = c.String(),
                        oilPressurePost = c.String(),
                        AmmeterPre = c.String(),
                        AmmeterPost = c.String(),
                        hornPre = c.String(),
                        hornPost = c.String(),
                        windshieldWipersPre = c.String(),
                        windshieldWipersPost = c.String(),
                        parkingBrakesPre = c.String(),
                        parkingBrakesPost = c.String(),
                        clutchPre = c.String(),
                        clutchPost = c.String(),
                        transmissionPre = c.String(),
                        transmissionPost = c.String(),
                        rearVisionMirrorPre = c.String(),
                        rearVisionMirrorPost = c.String(),
                        sterringPre = c.String(),
                        sterringPost = c.String(),
                        serviceBreaksPre = c.String(),
                        serviceBreaksPost = c.String(),
                        speedometerPre = c.String(),
                        speedometerPost = c.String(),
                        OtherItemsPre = c.String(),
                        OtherItemsPost = c.String(),
                        vehicleNumber = c.Int(nullable: false),
                        date = c.String(),
                        mechanicsSignature = c.String(),
                        driverSignature = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VehicleConditionReports");
        }
    }
}
