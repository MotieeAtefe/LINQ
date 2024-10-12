using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class FlightInformationSystem
    {
        public string FlightNumber { get; set; }    
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public override string ToString() => $"FlightNumber: {FlightNumber} - {DepartureCity} to {ArrivalCity}" + $"- Departure: {DepartureTime}, Arrival: {ArrivalTime} ";




    }
}
