using System.IO;
using System.Data.SqlClient;
using System;

namespace W2D2C2 {
    internal class Program {
        static void Main(string[] args) {
            const string PATH = @"C:\File\";


            Console.WriteLine("Exploring File IO Operations");

            Console.Write("Enter a file name with .txt: ");
            string fileName = PATH + Console.ReadLine(); // pcad16.txt

            StreamWriter streamWriter = null; // not associated with anything

            try {
                if (!File.Exists(fileName)) {
                    streamWriter = File.CreateText(PATH);
                    streamWriter.WriteLine($"File Created at {DateTime.Now}");
                    
                    Console.WriteLine("File Created");
                } else {
                    streamWriter = File.AppendText(PATH);
                    streamWriter.WriteLine($"File accessed at {DateTime.Now}");

                    Console.WriteLine("File Accessed");
                }
            } catch (Exception exception) {
                Console.WriteLine($"Exception {exception.Message}");
            } finally {
                if(streamWriter != null) {
                    streamWriter.Close();
                }
            }

            Console.WriteLine("Reading Contents from File..");
            using(StreamReader reader = new StreamReader(fileName)) {
                string line;
                while((line = reader.ReadLine()) != null) {
                    Console.WriteLine(line);
                    
                }
            }
        }
    }
}
