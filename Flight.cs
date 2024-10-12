using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Flight
    {
        public string FlightNumber {get; set;}
        public string DepartuerCity {get; set;}
        public string ArrivalCity {get; set; }
        public DateTime DepartuerTime {get; set; }
        public DateTime ArrivalTime { get; set; }
        public override string ToString() =>

            $"{FlightNumber} -" + $"{DepartuerCity} to {ArrivalCity}" +
            $"-Departuer: {DepartuerTime},Arrival:{ArrivalTime}";

    }
}
