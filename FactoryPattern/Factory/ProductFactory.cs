using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    public class ProductFactory
    {
        private static Dictionary<string, Type> _registProduct = new Dictionary<string, Type>();

        public static void RegistProduct(string id, Type productClass){
            _registProduct.Add(id, productClass);
        }

        public IProduct CreateProduct(string id)
        {
            var productType = _registProduct[id];
            var product = (IProduct)Activator.CreateInstance(productType);
            return product;
        }
    }
}
