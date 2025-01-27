using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1C2 {
    internal class Program {
        static void Main(string[] args) {
            int i; // stack, value type
            string s; // heap, reference type

            // strings are immutable, cannot change
            string address = string.Empty;
            address = "45";
            address = address + " Miller St.";

            // StringBuilder is a better way of doing this; uses one object
            StringBuilder sb = new StringBuilder();
            sb.Append(45);
            sb.Append(" Miller St.");
            Console.WriteLine(sb.ToString());

            string s1 = "  amazing ";
            Console.WriteLine($"Before Trim: {s1}\nAfter Trim: {s1.Trim()}");

            string header = "* A Short Play. *";
            var newHeader = header.Trim(new char[] { '*', ' ', '.', ',' });
            Console.WriteLine($"Before Trim: {header}\nAfter Trim: {newHeader}");
            Console.WriteLine(newHeader.Replace(' ', '-'));
            Console.WriteLine(newHeader.Remove(0, 4));

            char[] vowels = { 'A', 'E', 'I', 'O', 'U'};
            string vowelString = new string(vowels);
            foreach(char vowel in vowelString) {
                if (vowel == 'A') Console.WriteLine("A found");
            }

            string s2 = "Wake up early. Get to work.";
            string[] words = s2.Split(new char[] { ' ', ',', '.'} );
            foreach(string word in words) {
                if(word != string.Empty) Console.WriteLine(word);
            }
            string s3 = s2.Substring(0, 4);
            Console.WriteLine(s3);

            Console.WriteLine("Enter a string to check for palindrome");

            string s4 = Console.ReadLine();
            string s5 = new string(s4.Reverse().ToArray());
            if(s4 == s5) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }
    }
}
