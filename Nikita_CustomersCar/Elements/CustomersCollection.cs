using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersCar.Elements
{
    class CustomersCollection
    {
        public  List<Customer> Customers { get; private set; }

        public CustomersCollection() => Customers = new List<Customer>();

        public void Add(Customer consumer) => Customers.Add(consumer);
    }
}
