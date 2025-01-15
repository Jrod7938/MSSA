Console.Write("Display the multiplication table for what number: "); // Part 1
int.TryParse(Console.ReadLine(), out int num);

Solution.MultiplicationTable(num);


Console.Write("Amount of Odd Numbers to get the sum of: "); // Part 2
int.TryParse(Console.ReadLine(), out int amount);

Solution.NaturalNumberSum(amount);


Console.Write("\nAmount of rows: "); 
int.TryParse(Console.ReadLine(), out int rows);

Solution.RightAngleAstrix(rows); // Part 3
Solution.RightAngleNum(rows); // Part 4