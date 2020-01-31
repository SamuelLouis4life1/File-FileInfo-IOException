using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sa\Documents\New folder";

            try
            {
                ///  to use a short form of that declaration, may use without import system
                /// var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);


                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\myfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured !");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
