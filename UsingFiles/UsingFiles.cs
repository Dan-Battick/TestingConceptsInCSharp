using System;
using System.IO;

namespace UsingFiles
{
    class UsingFiles
    {
        
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Daniel Battick\source\repos\Tutorial Tests\UsingFiles\test.txt";
            WriteToNewFile(filePath, "I win!");
            WriteToExistingFile(filePath, "This is my sixth line.");
            WriteToExistingFile(filePath, "This is my seventh line.");
            WriteToExistingFile(filePath, "This is my eigth line.");
            WriteToExistingFile(filePath, "This is my ninth line.");
            ReadFromFile(filePath);
        }

        public static void ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string textInFile = File.ReadAllText(path);
                Console.WriteLine(textInFile);

                // Can be done using StreamReader
                /*using (StreamReader reader = File.OpenText(path))
                {
                    string str = "";
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }*/
            }
            else
            {
                Console.WriteLine("Error: The file does not exist.");
            }
        }

        public static void WriteToNewFile(string path, string input)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, $"{input}\n");

                // Can be done using StreamWriter
                /*using (StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine(input);
                    Console.WriteLine("File has been created!");
                }*/
            }
            else
            {
                Console.WriteLine("Error: The file already exists!");   
            }
        }

        public static void WriteToExistingFile(string path, string input)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, $"{input}\n");

                // Can be done using StreamWriter class
                /*using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(input);
                    Console.WriteLine("File has been updated.");
                }*/
            }
            else
            {
                Console.WriteLine("Error: The file does not exist.");
            }
            
        }
    }
}
