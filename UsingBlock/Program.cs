using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sa\source\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured !");
                Console.WriteLine(e.Message);
            }
        }
    }
}
