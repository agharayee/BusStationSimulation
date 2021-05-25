using BusStationSimulation.Library;
using System;

namespace BusStationSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Please Enter your Phone Number");
            var PhoneNumber = Console.ReadLine();
            Console.WriteLine("Please Enter your Destination");
            var destination = Console.ReadLine();
            Console.WriteLine("Please Enter your Next of Kin");
            var nextOfKin = Console.ReadLine();

            Passenger passenger = new Passenger(name, PhoneNumber, destination, nextOfKin);
            Console.WriteLine();
            passenger.GetTicket();
            Console.WriteLine();
            passenger.MethodCaller();
        }
    }
}
