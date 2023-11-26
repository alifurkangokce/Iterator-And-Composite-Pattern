using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositePattern
{
    public class Menu : IMenuComponent
    {
        private List<IMenuComponent> menuComponents = new List<IMenuComponent>();
        private string name;

        public Menu(string name)
        {
            this.name = name;
        }

        public void AddComponent(IMenuComponent component)
        {
            menuComponents.Add(component);
        }

        public void Print()
        {
            Console.WriteLine($"Menu: {name}");
            Console.WriteLine("Items:");

            foreach (var component in menuComponents)
            {
                component.Print();
            }
        }
    }
}
