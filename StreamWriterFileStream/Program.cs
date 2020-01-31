using System;
using System.IO;
namespace StreamWriterFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\sa\source\file1.txt";
            string targetpath = @"C:\Users\sa\source\file3.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
