using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public Product(string name, double price, int amount) 
        { 
            Name = name;
            Price = price;
            Amount = amount;
        }

        public double TotalValueInStock() {
            return Price * Amount;
        }

        public void AddProduct(int amount)
        {
            Amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"Produto: {Name}, R$ {Price}, Quantidade: {Amount}, Valor Total no Estoque: {TotalValueInStock()}";
        }
    }
}
