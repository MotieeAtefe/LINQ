namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FlightInformationSystem> list = new List<FlightInformationSystem>()
            {
                new FlightInformationSystem
                {
                                                FlightNumber="ABC123", DepartureCity="New York",
                                                ArrivalCity ="Los Angeles",
                                                DepartureTime = DateTime.Parse("2024-01-02 08:00"),
                                                 ArrivalTime =  DateTime.Parse("2024-01-02 08:00") },
                

                  new FlightInformationSystem
                {
                                                FlightNumber="ABC124", DepartureCity="Chicago",
                                                ArrivalCity ="Miami",
                                                DepartureTime = DateTime.Parse("2024-01-02 18:00"),
                                                 ArrivalTime =  DateTime.Parse("2024-01-02 20:00") },

            };
                  Console.WriteLine("Flight Information System");
                  ListAllFlights(flights: list);

        }
        static void ListAllFlights(List<FlightInformationSystem> flights)
        {
            Console.WriteLine("\nAll Flights:");
            flights.ForEach(Console.WriteLine);
        }
        static void SearchFlights(List<FlightInformationSystem> flights) 
        {
            Console.Write("Enter departure city: ");
            string departureCity = Console.ReadLine();

            Console.Write("Enter arrival city: ");
            string arrivalCity = Console.ReadLine();
            var matchingFlights = flights.Where(f => f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase)
                                                && f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine(matchingFlights.Any()
                ? "\nMatching Flights:\n" + string.Join("\n", matchingFlights)
                : "No matching flights found.");


        }

        

    }
}