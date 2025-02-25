using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace W7D2Assignment7._2 {
    internal class Solution {

        // Implement shell sort on an unsorted array of numbers.Take the array input from user.
        public static void Part1() {
            int size = GetInput<int>("Enter size of array: ");
            int[] array = new int[size];

            for(int i = 0; i < array.Length; i++) {
                array[i] = GetInput<int>($"Enter number [{i}]: ");
            }
            Console.Write("\nBefore Sort: ");
            foreach (int num in array) {
                Console.Write(num + " ");
            }

            ShellSort(array);
            Console.Write("\nAfter Sort: ");
            foreach (int num in array) {
                Console.Write(num + " ");
            }
        }
        private static void ShellSort(int[] A) {
            int n = A.Length;
            int gap = n / 2;

            while (gap > 0) {
                for (int i = gap; i < n; i++) {
                    int temp = A[i];
                    int j = i;
                    while (j >= gap && A[j - gap] > temp) {
                        A[j] = A[j - gap];
                        j -= gap;
                    }
                    A[j] = temp;
                }
                gap /= 2;
            }
        }

        // Given a string s, reverse only all the vowels in the string and return it.
        // The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
        public static void Part2() {
            string input = GetInput<string>("\nEnter a string: ");
            Console.WriteLine(ReverseVowels(input));
        }

        private static string ReverseVowels(string input) {
            char[] chars = input.ToCharArray();
            int first = 0;
            int last = input.Length - 1;
            
            while(first <= last) {
                if (!IsVowel(chars[first])) first++;
                else if (!IsVowel(chars[last])) last--;
                else {
                    char temp = chars[first];
                    chars[first] = chars[last];
                    chars[last] = temp;
                    first++;
                    last--;
                }
            }

            return new string(chars);
        }

        private static bool IsVowel(char letter) {
            return new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' }.Contains(letter);
        }

        // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        // An Anagram is a word or phrase formed by rearranging the letters of a different word
        // or phrase, typically using all the original letters exactly once.
        public static void Part3() {
            string word1 = GetInput<string>("\nEnter first word: ");
            string word2 = GetInput<string>("Enter second word: ");
            Console.WriteLine(IsAnagram(word1, word2));
        }

        private static bool IsAnagram(string word1, string word2) {
            return word1.ToLower().OrderBy(c => c).SequenceEqual(word2.ToLower().OrderBy(c => c));
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }catch(Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}
