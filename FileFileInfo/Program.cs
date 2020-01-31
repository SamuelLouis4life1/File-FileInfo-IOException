using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\sa\source\file1.txt";
            string targetPath = @"C:\Users\sa\source\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) ;
                Console.WriteLine(lines);  
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured !");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
