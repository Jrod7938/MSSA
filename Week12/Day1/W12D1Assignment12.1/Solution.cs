namespace W12D1Assignment12._1 {
    internal class Solution {
        // Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
        // Each letter in magazine can only be used once in ransomNote.
        internal static void Part1() {
            string word1 = GetInput<string>("Enter randsom note: ");
            string word2 = GetInput<string>("Enter magazine: ");

            Console.WriteLine(RandsomNote(word1, word2));
        }

        private static bool RandsomNote(string word1, string word2) {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char letter in word2) {
                if (letterCount.ContainsKey(letter)) letterCount[letter]++;
                else letterCount[letter] = 1;
            }

            foreach (char letter in word1) {
                if (!letterCount.ContainsKey(letter) || letterCount[letter] == 0) return false;
                letterCount[letter]--;
            }

            return true;
        }

        // Given the head of a singly linked list, return true if it is a palindrome or false otherwise
        internal static void Part2() {
            // 1 -> 2 -> 2 -> 1
            Node head = new Node(1, new Node(2, new Node(2, new Node(1, null))));
            Console.WriteLine(IsPalindrome(head));
        }

        private static bool IsPalindrome(Node head) {
            List<int> vals = new();

            for (Node? current = head; current != null; current = current.next) {
                vals.Add(current.val);
            }

            for (int i = 0, j = vals.Count - 1; i < j; i++, j--) {
                if (vals[i] != vals[j]) return false;
            }

            return true;
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
    }
}