using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
    public class MenuItem : IMenuComponent
    {
        private string name;
        private double price;

        public MenuItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine($"{name} - {price}$");
        }
    }
}
