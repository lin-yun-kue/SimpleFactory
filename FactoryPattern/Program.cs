using FactoryPattern.Factory;
using FactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static Program()
        {
            Activator.CreateInstance(typeof(OneProduct));
            Activator.CreateInstance(typeof(TwoProduct));
        }

        static void Main(string[] args)
        {
            var fac = new ProductFactory();
            var one = fac.CreateProduct("1");
            var two = fac.CreateProduct("2");
            one.Name();
            two.Name();
            Console.ReadLine();
        }
    }
}
