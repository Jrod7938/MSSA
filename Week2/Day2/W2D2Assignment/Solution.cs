using System;
using W2D2Assignment.Shapes;

namespace W2D2Assignment {
    internal class Solution {
        public static void Start(string[] args) {
            Console.WriteLine("Please Select an operation\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
            int.TryParse(Console.ReadLine(), out int operation);
            switch (operation) {
                case 1:
                    Add(args);
                    break;
                case 2:
                    Subtract(args);
                    break;
                case 3:
                    Multiply(args);
                    break;
                case 4:
                    Divide(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Start(args);
                    break;
            }
        }

        private static void Add(string[] args) {
            Console.WriteLine("Type of numbers to add?\n1. Int\n2. Double\n3. float");
            int.TryParse(Console.ReadLine(), out int type);
            switch (type) {
                case 1:
                    AddInt(args);
                    break;
                case 2:
                    AddDouble(args);
                    break;
                case 3:
                    AddFloat(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Add(args);
                    break;
            }
        }

        private static void Subtract(string[] args) {
            Console.WriteLine("Type of numbers to subtract?\n1. Int\n2. Double\n3. float");
            int.TryParse(Console.ReadLine(), out int type);
            switch (type) {
                case 1:
                    SubtractInt(args);
                    break;
                case 2:
                    SubtractDouble(args);
                    break;
                case 3:
                    SubtractFloat(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Subtract(args);
                    break;
            }
        }

        private static void Multiply(string[] args) {
            Console.WriteLine("Type of numbers to multiply?\n1. Int\n2. Double\n3. float");
            int.TryParse(Console.ReadLine(), out int type);
            switch (type) {
                case 1:
                    MultiplyInt(args);
                    break;
                case 2:
                    MultiplyDouble(args);
                    break;
                case 3:
                    MultiplyFloat(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Multiply(args);
                    break;
            }
        }

        

        private static void Divide(string[] args) {
            Console.WriteLine("Type of numbers to divide?\n1. Int\n2. Double\n3. float");
            int.TryParse(Console.ReadLine(), out int type);
            switch (type) {
                case 1:
                    DivideInt(args);
                    break;
                case 2:
                    DivideDouble(args);
                    break;
                case 3:
                    DivideFloat(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Divide(args);
                    break;
            }
        }

        private static void AddInt(string[] args) {
            if (args.Length == 2) {
                Maths.Add(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            } else if (args.Length >= 3) {
                int[] ints = Array.ConvertAll(args, int.Parse);
                Maths.Add(ints);
            }
        }

        private static void AddDouble(string[] args) {
            if (args.Length == 2) {
                Maths.Add(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
            } else if (args.Length >= 3) {
                double[] doubles = Array.ConvertAll(args, double.Parse);
                Maths.Add(doubles);
            }
        }

        private static void AddFloat(string[] args) {
            if (args.Length == 2) {
                Maths.Add(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]));
            } else if (args.Length >= 3) {
                float[] floats = Array.ConvertAll(args, float.Parse);
                Maths.Add(floats);
            }
        }

        private static void SubtractInt(string[] args) {
            if (args.Length == 2) {
                Maths.Subtract(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            } else if (args.Length >= 3) {
                int[] ints = Array.ConvertAll(args, int.Parse);
                Maths.Subtract(ints);
            }
        }

        private static void SubtractDouble(string[] args) {
            if (args.Length == 2) {
                Maths.Subtract(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
            } else if (args.Length >= 3) {
                double[] doubles = Array.ConvertAll(args, double.Parse);
                Maths.Subtract(doubles);
            }
        }

        private static void SubtractFloat(string[] args) {
            if (args.Length == 2) {
                Maths.Subtract(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]));
            } else if (args.Length >= 3) {
                float[] floats = Array.ConvertAll(args, float.Parse);
                Maths.Subtract(floats);
            }
        }

        private static void MultiplyInt(string[] args) {
            if (args.Length == 2) {
                Maths.Multiply(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            } else if (args.Length >= 3) {
                int[] ints = Array.ConvertAll(args, int.Parse);
                Maths.Multiply(ints);
            }
        }

        private static void MultiplyDouble(string[] args) {
            if (args.Length == 2) {
                Maths.Multiply(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
            } else if (args.Length >= 3) {
                double[] doubles = Array.ConvertAll(args, double.Parse);
                Maths.Multiply(doubles);
            }
        }

        private static void MultiplyFloat(string[] args) {
            if (args.Length == 2) {
                Maths.Multiply(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]));
            } else if (args.Length >= 3) {
                float[] floats = Array.ConvertAll(args, float.Parse);
                Maths.Multiply(floats);
            }
        }

        private static void DivideInt(string[] args) {
            if (args.Length == 2) {
                Maths.Divide(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
            } else if (args.Length >= 3) {
                int[] ints = Array.ConvertAll(args, int.Parse);
                Maths.Divide(ints);
            }
        }

        private static void DivideDouble(string[] args) {
            if (args.Length == 2) {
                Maths.Divide(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
            } else if (args.Length >= 3) {
                double[] doubles = Array.ConvertAll(args, double.Parse);
                Maths.Divide(doubles);
            }
        }

        private static void DivideFloat(string[] args) {
            if (args.Length == 2) {
                Maths.Divide(Convert.ToSingle(args[0]), Convert.ToSingle(args[1]));
            } else if (args.Length >= 3) {
                float[] floats = Array.ConvertAll(args, float.Parse);
                Maths.Divide(floats);
            }
        }

        public static void Part3() {
            Console.WriteLine("Please Select a Shape\n1. Circle\n2. Square");
            int.TryParse(Console.ReadLine(), out int selection);
            switch (selection) {
                case 1:
                    Console.Write("Enter the radius: ");
                    double.TryParse(Console.ReadLine(), out double radius);
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"Area of a Circle with radius: {radius} is = {circle.Area()}");
                    break;
                case 2:
                    Console.WriteLine("Enter the side: ");
                    double.TryParse(Console.ReadLine(), out double side);
                    Square square = new Square(side);
                    Console.WriteLine($"Area of a Square with side: {side} is = {square.Area()}");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Part3();
                    break;
            }
        }
    }

}

    
