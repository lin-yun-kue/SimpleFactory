using FactoryPattern.Factory;
using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Product
{
    public class TwoProduct : IProduct
    {
        static TwoProduct()
        {
            ProductFactory.RegistProduct("2", typeof(TwoProduct));
        }

        public void Name()
        {
            Console.WriteLine("Two Product");
        }
    }
}
