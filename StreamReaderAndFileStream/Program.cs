using System;
using System.IO;

namespace StreamReaderAndFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\sa\source\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured !");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            Console.ReadLine();
        }
    }
}
