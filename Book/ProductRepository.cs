using System.Collections.Generic;
using System.Linq;

namespace Data
{
    class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        
        public List<Product> GetProductsByPrice()
        {
            return _products.OrderBy(b => b.Price).ToList();
        }

    }
}
