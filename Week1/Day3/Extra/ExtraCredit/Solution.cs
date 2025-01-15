using System.Globalization;

class Solution {

    /*
        Display the multiplication table of a given integer
    */
    public static void MultiplicationTable(int number){
        for(int i = 0; i <= 12; i++){
            Console.WriteLine($"{number} X {i} = {number * i}");
        }
    }


    /*
        Display the n terms of odd natural numbers and their sums.
    */
    public static void NaturalNumberSum(int number) {
        if(number < 0) return;
        
        int sum = 0; 
        int oddNumber = 1;

        Console.Write("The odd numbers are: ");
        for(int i = 0; i < number; i++) {
            sum += oddNumber;
            Console.Write($"{oddNumber} ");
            oddNumber += 2;
        }

        Console.WriteLine($"\nThe sum of the first {number} odd numbers is {sum}");
    }

    /*
        Create a right angle triangle with repeating
        '*' every row.
    */
    public static void RightAngleAstrix(int rows) {
        for(int i = 0; i < rows; i++){
            for(int j = 0; j <= i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    /*
        Display a rigth angle triangle with a repeating
        number in every row.
    */
    public static void RightAngleNum(int rows) {
        for(int i = 1; i < rows+1; i++){
            for(int j = 1; j <= i; j++){
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }
    }
}