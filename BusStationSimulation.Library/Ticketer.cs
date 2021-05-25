using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationSimulation.Library
{
    public class Ticketer
    {
        private string Id { get; set; }
        private string ticketerName { get; set; } = "Emmanuel";

        public Tickets IssueTicket(Passenger passenger)
        {
            var tickets = TicketIssuer(passenger);
            return tickets;
        }
        private Tickets TicketIssuer(Passenger passenger)
        {
            Bus bus = new Bus();
            Tickets tickets = new Tickets
            {
                Id = Guid.NewGuid(),
                Name = passenger.Name,
                issuedBy = ticketerName,
                PhoneNumber = passenger.PhoneNumber,
                DepartureTime = DateTime.Now.AddHours(1),
                Destination = passenger.Destination,
                NextOfKin = passenger.NextOfKin,
                Amount = 10000,
                BusPlateNumber = bus.GetBusNumber,
                SeatNumber = 18,

            };
            return tickets;
        }

        private List<Tickets> IssueTicket(List<Passenger> passengers)
        {
            Bus bus = new Bus();
            List<Tickets> multipleTickets = new List<Tickets>();

            foreach (var ticket in passengers)
            {
                Tickets tickets = new Tickets
                {

                    Id = Guid.NewGuid(),
                    Name = ticket.Name,
                    issuedBy = ticketerName,
                    PhoneNumber = ticket.PhoneNumber,
                    DepartureTime = DateTime.Now.AddHours(1),
                    Destination = ticket.Destination,
                    NextOfKin = ticket.NextOfKin,
                    Amount = 10000,
                    BusPlateNumber = bus.GetBusNumber,
                };
                
                multipleTickets.Add(tickets);
                
            }
            return multipleTickets;

        }
    }
}
