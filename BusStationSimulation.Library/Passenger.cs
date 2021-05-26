using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Passenger : BioClass
    {
        public string Destination;
        
        private static readonly Random r = new Random(DateTime.Now.Second);
        public int SeatNumber => r.Next(1, 19);


        Driver driver = new Driver();
        public Passenger(string name, string phonenumber, string destination, string NextofKin)
        {
            base.Name = name;
            base.PhoneNumber = phonenumber;
            base.NextOfKin = NextofKin;
            Destination = destination;
            
           
        }

        
        public void GetTicket()
        {
            Passenger passenger = new Passenger(Name, PhoneNumber, Destination, NextOfKin);
            Ticketer myTicket = new Ticketer();
            var ticket = myTicket.TicketIssuer(passenger); ;
            Console.WriteLine($"Ticket Reference Number: {ticket.ReferenceNumber}");
            Console.WriteLine($"Name: {ticket.Name}");
            Console.WriteLine($"Seat Number: {ticket.SeatNumber}");
            Console.WriteLine($"Ticket Issued by: {ticket.issuedBy}");
            Console.WriteLine($"Next of Kin: {ticket.NextOfKin}");
            Console.WriteLine($"Departure Time: {ticket.DepartureTime}");
            Console.WriteLine($"Destination: {ticket.Destination}");
            Console.WriteLine($"Amount: {ticket.Amount}");
            Console.WriteLine($"Bus Plate Number: {ticket.BusPlateNumber}");
        }
        
        

        private void Board()
        {
            Console.WriteLine("You are now ready for Boarding");
            Console.WriteLine("Press 1 to Enter Bus, Press 2 to Exit , Press 3 to buy Gala");
            var boardingEntry = Console.ReadLine();
            if (boardingEntry == "1")
            {
                Console.WriteLine($"Please show your ticket");
                GetTicket();
                Thread.Sleep(3000);
                Console.WriteLine($"Thanks for using ISE Transport, Do have a safe Journing");
            }
            else if (boardingEntry == "2")
            {
                Console.WriteLine("Thanks for trusting us");
                Environment.Exit(1);
            }
            else if(boardingEntry == "3")
                Console.WriteLine("Idiot you eat to much");
        }

        public void MethodCaller()
        {
            Board();
        }

    }
}
