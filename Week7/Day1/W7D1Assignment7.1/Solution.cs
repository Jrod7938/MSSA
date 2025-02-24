using System.Text;

namespace W7D1Assignment7._1 {
    internal class Solution {

        // You are a student who has recently taken an exam with your classmates.However, 
        // the professor has not yet provided the students with a sorted list of exam scores.
        // To make things easier, you write a program to sort exam scores in ascending order 
        // using the selection sort algorithm.This way, you can obtain the sorted list of 
        // scores and see how you performed compared to your classmates.Also, you choose
        // selection sort since that is an easy way of implementation.
        internal static void Part1() {
            int size = GetInput<int>("Enter the size of the array: ");
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++) {
                array[i] = GetInput<int>($"Enter array[{i}]: ");
            }
            Console.WriteLine();
            SelectionSort(array);
            foreach (int num in array) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private static void SelectionSort(int[] array) {
            int minIndex = 0;
            int temp = 0;
            for(int i = 0; i < array.Length - 1; i++) {
                minIndex = i;
                for(int j = i + 1; j < array.Length; j++) {
                    if (array[j] < array[minIndex]) {
                        minIndex = j;
                    }
                }
                if(minIndex != i) {
                    temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        // You are given two strings word1 and word2.Merge the strings by adding letters in 
        // alternating order, starting with word1.If a string is longer than the other, 
        // append the additional letters onto the end of the merged string. Return 
        // merged string.
        internal static void Part2() {
            string word1 = GetInput<string>("Enter the first word to merge: ");
            string word2 = GetInput<string>("Enter the second word to merge: ");
            Console.WriteLine(string.Join(" ", MergeStringsAlternating(word1, word2)));
        }

        private static string MergeStringsAlternating(string word1, string word2) {
            int word1Pointer = 0;
            int word2Pointer = 0;
            StringBuilder answer = new StringBuilder();
            while (word1Pointer < word1.Length || word2Pointer < word2.Length) {
                if (word1Pointer < word1.Length) {
                    answer.Append(word1[word1Pointer]);
                    word1Pointer++;
                }
                if (word2Pointer < word2.Length) {
                    answer.Append(word2[word2Pointer]);
                    word2Pointer++;
                }
            }
            return answer.ToString();
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}