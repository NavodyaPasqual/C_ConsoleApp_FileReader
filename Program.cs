using System;
using System.IO;

namespace C_ConsoleApp_FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //string directoryPath = @"E:\\Job Interview helper\\Filereader\\";

            Console.Write("Enter Directory path: ");
            string directoryPath;

            try
            {
                directoryPath = Console.ReadLine();
                if (Directory.Exists(directoryPath))
                    fileReader(directoryPath);
                else
                {
                    Console.Write("No path exist.\nEnter new Directory path:");
                    directoryPath = Console.ReadLine();
                    fileReader(directoryPath);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Path is null. Exception " + e);
            }

        }
        //File Reader function
        public static void fileReader(string folder)
        {
            //Filtering txt file
            string[] filePaths = Directory.GetFiles(folder, "*.txt", SearchOption.AllDirectories);
            foreach (string filePath in filePaths)
            {
                //Print file path
                Console.WriteLine("\nFILE PATH - " + filePath);
                //Print file name
                Console.WriteLine("\tFILE NAME - " + Path.GetFileName(filePath));
                //Print file content
                string[] lines = File.ReadAllLines(filePath);
                Console.Write("\tFILE CONTENT - ");
                foreach (string line in lines)
                    Console.Write(line + " ");
                Console.WriteLine("\n");
            }

        }
    }
}
