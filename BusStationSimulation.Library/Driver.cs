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
            Console.WriteLine($"Good day ladies and gents. I am the captain for today's journing. We are starting our journing at {DateTime.Now} we should arrive at {DateTime.Now.AddHours(4).AddMinutes(30)}");
        }
    }
}
