using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C3 {
    internal class Program {
        static void Main(string[] args) {

            DriveInfo drive = new DriveInfo(@"D:\");
            Console.WriteLine($"Drive Name {drive.Name}\nDrive Size: {drive.TotalSize}\nDrive Free Space: {drive.TotalFreeSpace}");
            DirectoryInfo info = new DirectoryInfo(@"D:\Nerd");
            DirectoryInfo[] directories = info.GetDirectories();
            Console.WriteLine("Directories: ");
            foreach (DirectoryInfo directory in directories) { 
                Console.WriteLine(directory.Name);
            }

            Console.WriteLine("Files: ");
            FileInfo[] fileInfos = info.GetFiles();
            foreach(FileInfo fileInfo in fileInfos) {
                Console.WriteLine($"File Name: {fileInfo.Name}\nFile Created: {fileInfo.CreationTime}");
            }
        }
    }
}
