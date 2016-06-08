using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneRemastered.Models
{
    public class VehicleConditionReport
    {
        [Key]
        public int Id { get; set; }
        public string brakeLinesToTrailerPre { get; set; }
        public string brakeLinesToTrailerPost { get; set; }
        public string electricLinesToTrailerPre { get; set; }
        public string electricLinesToTrailerPost { get; set; }
        public string driveLinePre { get; set; }
        public string driveLinePost { get; set; }
        public string couplingDevicePre { get; set; }
        public string couplingDevicePost { get; set; }
        public string tiresandWheelsPre { get; set; }
        public string tiresandWheelsPost { get; set; }
        public string springsPre { get; set; }
        public string springsPost { get; set; }
        public string bodyPre { get; set; }
        public string bodyPost { get; set; }
        public string glassPre { get; set; }
        public string glassPost { get; set; }
        public string torchesAndReflectorsAndLanternsPre { get; set; }
        public string torchesAndReflectorsAndLanternsPost { get; set; }
        public string fusersPre { get; set; }
        public string fusersPost { get; set; }
        public string flagsPre { get; set; }
        public string flagsPost { get; set; }
        public string spareBulbsPre { get; set; }
        public string spareBulbsPost { get; set; }
        public string fusesPre { get; set; }
        public string fusesPost { get; set; }
        public string fireExtinquisherPre { get; set; }
        public string fireExtinquisherPost { get; set; }
        public string tireChainsPre { get; set; }
        public string tireChainsPost { get; set; }
        public string afterStartingEnginePre { get; set; }
        public string afterStartingEnginePost { get; set; }
        public string fuelSystemPre { get; set; }
        public string fuelSystemPost { get; set; }
        public string coolingSystemPre { get; set; }
        public string coolingSystemPost { get; set; }
        public string enginePre { get; set; }
        public string enginePost { get; set; }
        public string leaksPre { get; set; }
        public string leaksPost { get; set; }
        public string lightsPre { get; set; }
        public string lightsPost { get; set; }
        public string tailPre { get; set; }
        public string tailPost { get; set; }
        public string stopAndTurnPre { get; set; }
        public string stopAndTurnPost { get; set; }
        public string clearanceAndMarkerPre { get; set; }
        public string clearanceAndMarkerPost { get; set; }
        public string reflectorsPre { get; set; }
        public string reflectorsPost { get; set; }
        public string airPressureWarningDevicePre { get; set; }
        public string airPressureWarningDevicePost { get; set; }
        public string oilPressurePre { get; set; }
        public string oilPressurePost { get; set; }
        public string AmmeterPre { get; set; }
        public string AmmeterPost { get; set; }
        public string hornPre { get; set; }
        public string hornPost { get; set; }
        public string windshieldWipersPre { get; set; }
        public string windshieldWipersPost { get; set; }
        public string parkingBrakesPre { get; set; }
        public string parkingBrakesPost { get; set; }
        public string clutchPre { get; set; }
        public string clutchPost { get; set; }
        public string transmissionPre { get; set; }
        public string transmissionPost { get; set; }
        public string rearVisionMirrorPre { get; set; }
        public string rearVisionMirrorPost { get; set; }
        public string sterringPre { get; set; }
        public string sterringPost { get; set; }
        public string serviceBreaksPre { get; set; }
        public string serviceBreaksPost { get; set; }
        public string speedometerPre { get; set; }
        public string speedometerPost { get; set; }
        public string OtherItemsPre { get; set; }
        public string OtherItemsPost { get; set; }
        public int vehicleNumber { get; set; }
        public string date { get; set; }
        public string mechanicsSignature { get; set; }
        public string driverSignature { get; set; }



    }
}