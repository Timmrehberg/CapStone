using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneRemastered.Models
{
    public class HourBreakdown
    {
        [Key]
        [Display(Name = "Hours Worked")]
        public int Hoursworked { get; set; }
        [Display(Name = "Vehicle Numbers")]
        public string VehicleNumbers { get; set; }
        public string Signature { get; set; }
        public string CoDriver { get; set; }
        [Display(Name = "On Time ")]
        public string OnDutyHours { get; set; }
        [Display(Name = "Off Time")]
        public string OffDutyHours { get; set; }
        [Display(Name = "On Time")]
        public string OnDutyHours2 { get; set; }
        [Display(Name = "Off Time")]
        public string OffDutyHours2 { get; set; }
        [Display(Name = "On Time")]
        public string OnDutyHours3 { get; set; }
        [Display(Name = "Off Time")]
        public string OffDutyHours3 { get; set; }
        [Display(Name = "Total Hours")]
        public string TotalHours { get; set; }
    }
}