using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Passenger : BioClass
    {
        public string Destination;
        public int SeatNumber { get; set; }
        //Random round = new Random();
        //int seat = round.Next(1, 18);
        Driver driver = new Driver();
        public Passenger(string name, string phonenumber, string destination, string NextofKin)
        {
            Name = name;
            PhoneNumber = phonenumber;
            NextOfKin = NextofKin;
            Destination = destination;
           
        }

        
        public void GetTicket()
        {
            Passenger passenger = new Passenger(Name, PhoneNumber, Destination, NextOfKin);
            Ticketer myTicket = new Ticketer();
            var ticket = myTicket.IssueTicket(passenger); ;
            Console.WriteLine("Your Ticket is as follows:");
            Console.WriteLine($"Ticket Id: {ticket.Id}");
            Console.WriteLine($"Name: {ticket.Name}");
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

            }
            else if (boardingEntry == "2")
                Console.WriteLine("Thanks for trusting us");
            else if(boardingEntry == "3")
                Console.WriteLine("Idiot you eat to much");
        }

        public void MethodCaller()
        {
            Board();
        }

    }
}
