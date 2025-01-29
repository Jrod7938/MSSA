namespace W3D3C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintFavSeason(Seasons.Summer);
        }

        static void PrintFavSeason(Seasons season) {
            int val = (int)season;
            Console.WriteLine($"Your favourite season is {season} - {val}.");
            Console.WriteLine($"Error Code example: {ErrorCodes.Internal_Server_Error}");
        }
    }
}
