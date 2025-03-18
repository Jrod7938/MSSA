using Microsoft.Data.SqlClient;

namespace W10D2C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ: language integrated query 
            // "select * from Emp"
            int[] scores = { 23, 45, 12, 400, 355 };

            var scoreResults = from score in scores
                               where score > 40
                               select score;

            Console.WriteLine("Scores over 40");
            foreach (var item in scoreResults) Console.WriteLine(item);

            List<string> names = new List<string> { "Bill", "Alex", "James", "Rob" };
            var result_A = from name in names
                           where name.StartsWith('A')
                           select name;


            var result_B = (from name in names
                           where name.StartsWith('A')
                           select name).ToList(); // force query now

            names.Add("Andrew");
            // query execution is deferred
            foreach (string name in result_A) Console.WriteLine(name);

        }
    }
}
