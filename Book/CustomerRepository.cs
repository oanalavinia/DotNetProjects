using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class CustomerRepository
    {
        private readonly List<Customer> _products = new List<Customer>();

        public List<Customer> GetProductsByEmail()
        {
            return _products.OrderBy(b => b.Email).ToList();
        }
    }
}
