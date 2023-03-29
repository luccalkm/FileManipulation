using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Exercicios;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Write your file full directory (for example use: C:\\tmp\\file1.txt): ");
        string filePath = Console.ReadLine();
        //string filePath = @"C:\tmp\file1.txt";
        string targetFolder = Path.GetDirectoryName(filePath) + "\\";
        string outFile = targetFolder + "file2.txt";

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            List<Product> products = new List<Product>();

            using(StreamWriter sw = File.AppendText(outFile))
            {
                foreach(string line in lines)
                {
                    string[] productInfo = line.Split(',');
                    string name = productInfo[0];
                    double price = double.Parse(productInfo[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(productInfo[2]);

                    Product product = new Product(name, price, quantity);
                    products.Add(product);
                    sw.WriteLine(product.Name + ',' + product.TotalPrice(price, quantity));
                }
            }
        }
        catch(IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}