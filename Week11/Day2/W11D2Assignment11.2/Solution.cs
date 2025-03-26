
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;
using System;

namespace W11D2Assignment11._2 {
    internal class Solution {
        // You are given an array prices where prices[i] is the
        // price of a given stock on the ith day.
        // You want to maximize your profit by choosing a single day to buy
        // one stock and choosing a different day in the future to sell that stock.
        // Return the maximum profit you can achieve from this transaction.If you
        // cannot achieve any profit, return 0.
        internal static void Part1() {
            int n = GetInput<int>("Enter the number of days: ");
            int[] prices = new int[n];

            for (int i = 0; i < n; i++) prices[i] = GetInput<int>($"Enter price for day {i + 1}: ");
            

            int maxProfit = MaxProfit(prices);
            Console.WriteLine($"Max Profit: {maxProfit}");
        }

        private static int MaxProfit(int[] prices) {
            if (prices.Length == 0) return 0;

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices) {
                if (price < minPrice) {
                    minPrice = price;
                } else {
                    maxProfit = Math.Max(maxProfit, price - minPrice); 
                }
            }

            return maxProfit;
        }

        // Given the head of a singly linked list, reverse the list, and return the reversed list.
        internal static void Part2() {
            int n = GetInput<int>("Enter the number of nodes: ");
            if (n <= 0) {
                Console.WriteLine("Empty list.");
                return;
            }

            ListNode head = null, tail = null;

            for (int i = 0; i < n; i++) {
                int value = GetInput<int>($"Enter value for node {i + 1}: ");
                if (head == null) {
                    head = new ListNode(value);
                    tail = head;
                } else {
                    tail.next = new ListNode(value);
                    tail = tail.next;
                }
            }

            Console.WriteLine("Original List:");
            PrintList(head);

            head = ReverseList(head);

            Console.WriteLine("Reversed List:");
            PrintList(head);
        }

        private static ListNode ReverseList(ListNode head) {
            ListNode prev = null;
            ListNode current = head;

            while (current != null) {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        private static void PrintList(ListNode node) {
            while (node != null) {
                Console.Write(node.val + " -> ");
                node = node.next;
            }
            Console.WriteLine("null");
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