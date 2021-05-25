using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Tickets : BioClass
    {
        public Guid Id { get; set; }
        public string issuedBy { get; set; }
        public string Destination { get; set; }
        public Decimal Amount { get; set; }
        public DateTime DepartureTime { get; set; } = DateTime.Now.AddHours(1);
        public string BusPlateNumber;
        public int SeatNumber { get; set; }



    }
}
