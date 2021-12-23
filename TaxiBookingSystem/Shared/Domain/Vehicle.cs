using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingSystem.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public string LicensePlateNumber { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public virtual List<Driver> Drivers { get; set; }
    }
}
