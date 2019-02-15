using FactoryPattern.Factory;
using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Product
{
    public class OneProduct : IProduct
    {
        static OneProduct()
        {
            ProductFactory.RegistProduct("1", typeof(OneProduct));
        }

        public void Name()
        {
            Console.WriteLine("One Product");
        }
    }
}
