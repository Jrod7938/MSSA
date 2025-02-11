namespace W5D2C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PATH = @"C:\Users\guana";
            //string[] directories = Directory.GetDirectories(PATH);

            //foreach(string directory in directories) {
            //    Console.WriteLine(directory);
            //    string[] subDirectory = Directory.GetDirectories(directory);
            //    foreach(string subDir in subDirectory) {
            //        Console.WriteLine(subDir);
            //        // too much work!! Can be done with recursion
            //    }
            //}

            PrintAllDirectories(PATH, 8);
        }

        private static void PrintAllDirectories(string path, int depth) {
            if (depth <= 0) return;
            try {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories) {
                    Console.WriteLine(directory);
                    PrintAllDirectories(directory, depth - 1);
                }
            } catch (Exception exeption) {
                Console.WriteLine($"Access denied to path: {exeption.Message}");
            }
        }
    }
}
