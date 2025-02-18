
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace W6D1Assignment6._1 {
    internal class Solution {
        // Implement a single linked list with each node representing a house.
        // You may add data in it like house number, brief address, type of
        // house(like Ranch, Colonial) . each house(node) will be linked to
        // next.Give facility to the user to search a house by its number
        // and then display the details. (Windows / Console)
        internal static void Part1() {
            HouseLinkedList houses = new HouseLinkedList();
            int amountOfHomes = GetInput<int>("How many homes would you like to add?");
            for(int i = 0; i < amountOfHomes; i++) {
                House house = GetInput<House>("What type of house is this? (Colonial, Ranch)");
                int houseNumber = GetInput<int>("What is the house number?");
                string address = GetInput<string>("What is the address?");
                houses.AddLast(house, houseNumber, address);
            }

            int houseToFind = GetInput<int>("What house number would you like to find?");
            if (houses.Search(houseToFind, out HouseNode houseNode)) {
                Console.WriteLine(houseNode.ToString());
            } else {
                Console.WriteLine("House not found.");
            }
        }

        // Explore Linkedlist class from C# library.
        internal static void Part2() {
            LinkedList<string> houseList = new LinkedList<string>();

            // Adding elements
            houseList.AddLast("Colonial - 101, Main Street");
            houseList.AddLast("Ranch - 202, Elm Avenue");
            houseList.AddFirst("Victorian - 303, Oak Road");

            Console.WriteLine("Houses in the list:");
            foreach (var house in houseList) {
                Console.WriteLine(house);
            }

            // Searching for a specific house
            string searchHouse = "Ranch - 202, Elm Avenue";
            LinkedListNode<string> node = houseList.Find(searchHouse);
            if (node != null) {
                Console.WriteLine($"\nHouse found: {node.Value}");
            } else {
                Console.WriteLine("\nHouse not found.");
            }

            // Removing a house
            houseList.Remove("Colonial - 101, Main Street");
            Console.WriteLine("\nAfter removing Colonial - 101:");
            foreach (var house in houseList) {
                Console.WriteLine(house);
            }
        }

        // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        // Note that you must do this in-place without making a copy of the array.
        // Example 1:
        // Input: nums = [0, 1, 0, 3, 12]
        // Output: [1, 3, 12, 0, 0]
        // Example 2:
        // Input: nums = [0]
        // Output: [0]
        internal static void Part3() {
            int size = GetInput<int>("How many numbers would you like to add?");
            int[] nums = new int[size];
            for (int i = 0; i < size; i++) {
                nums[i] = GetInput<int>($"Enter number [{i}]");
            }

            Console.WriteLine("Before moving zeroes:");
            foreach (var num in nums) {
                Console.WriteLine(num);
            }

            MoveZeroes(nums);
            Console.WriteLine("After moving zeroes:");
            foreach (var num in nums) {
                Console.WriteLine(num);
            }
        }

        private static void MoveZeroes(int[] nums) {
            int pointer = 0;
            for(int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    (nums[pointer], nums[i]) = (nums[i], nums[pointer]);
                    pointer++;
                }
            }
        }

        private static T GetInput<T>(string prompt) {
            Console.WriteLine(prompt);
            try {
                string input = Console.ReadLine();

                // Special handling for enum types
                if (typeof(T).IsEnum) {
                    if (Enum.TryParse(typeof(T), input, true, out object result)) {
                        return (T)result;
                    } else {
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        return GetInput<T>(prompt);
                    }
                }

                return (T)Convert.ChangeType(input, typeof(T));
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}