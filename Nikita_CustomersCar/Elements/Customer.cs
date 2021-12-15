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

        public Customer(string name, int phoneNumber, string carModel)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            CarModel = carModel;
        }

        public override string ToString() => $"Name: {Name} \nNumber: {PhoneNumber} \nModel: {CarModel}";
        public static List<Customer> CustomersList()
        {
            List<Customer> customers = new List<Customer>()
            {
            new Customer("Jack", 1353457657, "XC90"),
            new Customer("Jones", 1575677897, "570S"),
            new Customer("Carl", 1464564678, "911")
            };

            return customers;
        }
    }
}

