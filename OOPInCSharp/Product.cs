using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Product
    {
        public string _name;
        public double _price;
        public int _amount;

        public Product()
        {
            _amount = 0;
        }
        public Product(string name, double price) : this()
        {
            _name = name;
            _price = price;
        }

        public Product(string name, double price, int amount) : this(name, price)
        { 
            _amount = amount;
        }

        public string Get_name() {  return _name; }

        public double Get_price() { return _price; }

        public int Get_amount() { return _amount; }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetAmount(int amount)
        {
            _amount = amount;
        }

        public double TotalValueInStock() {
            return _price * _amount;
        }

        public void AddProduct(int amount)
        {
            _amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            _amount -= amount;
        }

        public override string ToString()
        {
            return $"Produto: {_name}, R$ {_price}, Quantidade: {_amount}, Valor Total no Estoque: {TotalValueInStock()}";
        }
    }
}
