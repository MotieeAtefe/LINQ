namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void ListAllFligts(List<Flight> fligts)
        {
            Console.WriteLine("\nAllFlights: ");
            fligts.ForEach(Console.WriteLine);
        }
        static void SearchFligt(List<Flight> fligts)
        {
            var matchingFlights = fligts.Where(f=>f.DepartuerCity.Equals())
        }

    }
}