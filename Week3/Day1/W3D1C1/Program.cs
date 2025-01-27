using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1C1 {
    internal class Program {
        static void Main(string[] args) {

            string[] names = { "Amy", "Abby", "Adam", "Zoe", "Frank" };

            // Linq: Language integrated Query Expressions
            // Select Name from Tablename Where... sql 
            var names_A = from name in names            // requires from, where, and select
                          where name.StartsWith("A")
                          select name;

            // var names_A2 = names.Where(name => name.StartsWith("A")); SAME THING

            Console.WriteLine("Names starting with A");
            foreach(var name in names_A) {
                Console.WriteLine(name);
            }

            Console.WriteLine($"{DateTime.Now.ToLongDateString()}");

            Console.WriteLine("Enter your date of birth in YYYY/MM/DD");

            var dob = Convert.ToDateTime(Console.ReadLine());
            var age = CalculateAge(dob);
            Console.WriteLine($"You are {age} years old.");
            var months = ((DateTime.Now.Year * 12) + DateTime.Now.Month) - ((dob.Year*12)+ dob.Month);
            float preciseAge = months / 12.0f;
            Console.WriteLine($"You are {preciseAge} old.");
        }

        private static int CalculateAge(DateTime date) {
            return DateTime.Now.Year - date.Year;
        }
    }
}
