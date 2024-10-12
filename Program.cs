using System.ComponentModel.Design;

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
            Console.WriteLine("\nFlight Information System");
            while(true) 
            {
                Console.WriteLine("\n1. List all flights");
                Console.WriteLine("2. Search for flights");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");

                if(int.TryParse(Console.ReadLine(), out int choice)) 
                { 
                    switch(choice) 
                    {
                        case 1:
                            ListAllFlights(list);
                            break;
                        case 2:
                            SearchFlights(list); 
                            break;
                        case 3:
                            Console.WriteLine("Exit program, Have a good times!");
                            return;
                        default:
                            Console.WriteLine("Invalid choise");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }

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