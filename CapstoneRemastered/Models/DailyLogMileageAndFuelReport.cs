using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneRemastered.Models
{
    public class DailyLogMileageAndFuelReport
    {
        [Key]
        public int Id { get; set; }
        public string Driver { get; set; }
        [Display(Name = "Work Date")]
        public string DateofWork { get; set; }
        public string Owner { get; set; }
        [Display(Name = "Tractor Number")]
        public int Tractornumber { get; set; }
        [Display(Name = "Trailer Number")]
        public int Trailernumber { get; set; }
        [Display(Name = "Pro Number")]
        public int Pronumber { get; set; }
        public string State { get; set; }
        [Display(Name = "Total Miles Driven")]
        public int Totalmilesdriven { get; set; }
        [Display(Name = "Total Gas Purchased")]
        public double Totalgaspurchased { get; set; }
        [Display(Name = "Routes Traveled")]
        public string Routestraveled { get; set; }
        [Display(Name = "Odometer Start")]
        public int Odometerstart { get; set; }
        [Display(Name = "Odometer Finish")]
        public int Odometerfinish { get; set; }


    }
}
 