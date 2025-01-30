using System;

namespace W3D4C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodMenu weekendMenu = new FoodMenu(new List<string> { "Pizza", "Burgers", "Pasta", "Salad" });
            for(int i = 0; i < weekendMenu.Count; i++) {
                Console.WriteLine(weekendMenu[i]);
            }

            weekendMenu[weekendMenu.Count] = GetInput<string>("Enter a new food item: ");

            for (int i = 0; i < weekendMenu.Count; i++) {
                Console.WriteLine(weekendMenu[i]);
            }
        }

        private static T GetInput<T>(T v) {
            Console.Write(v);
            string ?input = Console.ReadLine();
            try {
                var userInput = Convert.ChangeType(input, typeof(T));
                return (T)userInput;
            } catch (Exception exception){
                Console.WriteLine($"Please enter a type of {typeof(T).Name}.\nError Message: {exception.Message}");
                return GetInput<T>(v);
            }
        }
    }
}
