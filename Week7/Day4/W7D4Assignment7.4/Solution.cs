namespace W7D4Assignment7._4 {
    internal class Solution {

        // Design a parking system for a parking lot.The parking lot has three kinds 
        // of parking spaces: big, medium, and small, with a fixed number of slots for each size.
        // Implement the ParkingSystem class:
        // ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class. 
        // The number of slots for each parking space are given as part of the constructor.
        // bool addCar(int carType) Checks whether there is a parking space of carType for the car that 
        // wants to get into the parking lot. carType can be of three kinds: big, medium, or small, 
        // which are represented by 1, 2, and 3 respectively.A car can only park in a parking space of 
        // its carType. If there is no space available, return false, else park the car in that size 
        // space and return true.
        public static void Part1() {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine("Big: 1, Medium = 1, Small = 0");
            Console.WriteLine("Big: " + parkingSystem.AddCar(1)); // true
            Console.WriteLine("Medium: " + parkingSystem.AddCar(2)); // true
            Console.WriteLine("Small: " + parkingSystem.AddCar(3)); // false
            Console.WriteLine("Big: " + parkingSystem.AddCar(1)); // false
        }
    }
}