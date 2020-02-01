using System;
using System.Globalization;
using PathDirectoryFileExercices.Entities;
using System.IO;

/// <summary>
/// a program to read the path of a .csv file containing the data of items sold. Each item has a name, unit price and quantity, separated by a comma.
/// You must generate a new file called "summary.csv", located in a subfolder called "out" from the original folder of the source file, 
/// containing only the name and the total amount for that item (unit price multiplied by the quantity),
/// </summary>

namespace PathDirectoryFileExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();
            
            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sammary";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + ", " + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
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
