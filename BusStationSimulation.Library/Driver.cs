using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Driver : BioClass
    {
        Bus bus = new Bus();
       private string busPlateNumber;
        public string GetBusNumber
        {
            get
            {
                return busPlateNumber;
            }
            set
            {
                busPlateNumber = bus.GetBusNumber;
            }
        }

        public void Departure()
        {
            Console.WriteLine("We have started Moving have a wonderful Ride");
        }
    }
}
