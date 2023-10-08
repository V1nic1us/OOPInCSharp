using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Produto");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o preço");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade");
            int amount = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, amount);
            PrintProduct(product);

            Console.WriteLine("Digite a quantidade para ser adicionado");
            amount = int.Parse(Console.ReadLine());
            PrintProduct(product);
            Console.WriteLine("Digite a quantidade para ser retirada");
            amount = int.Parse(Console.ReadLine());
            PrintProduct(product);

        }

        static void PrintProduct(Product product)
        {
            Console.WriteLine();
            Console.WriteLine(product);
            Console.WriteLine();
        }
    }
}
