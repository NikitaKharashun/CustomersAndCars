using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersCar.Elements
{
    class Customer
    {
        public string Name { get; private set; }
        public int PhoneNumber { get; private set; }
        public string CarModel { get; private set; }
        public List<Customer> Customers { get; private set; }

        public Customer(string name, int phoneNumber, string carModel)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            CarModel = carModel;
        }

        public override string ToString() => $"Name: {Name} \nNumber: {PhoneNumber} \nModel: {CarModel}";
        public void Add(List<Customer> customers, Customer consumer) => customers.Add(consumer);
    }
}

