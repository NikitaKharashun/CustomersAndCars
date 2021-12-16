using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_CustomersCar.Elements;

namespace Nikita_CustomersCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();

            customers.Add(new Customer("Jack", 1353457657, "XC90"));
            customers.Add(new Customer("Jones", 1575677897, "570S"));
            customers.Add(new Customer("Carl", 1464564678, "911"));

            var cars = new List<Car>();

            cars.Add(new Car("911", "Porshe", 2011, "Black"));
            cars.Add(new Car("570S", "McLaren", 2015, "Orange"));
            cars.Add(new Car("XC90", "Volvo", 2008, "White"));

            var consumers = from cust in customers join car in cars on cust.CarModel equals car.Model select new { customer = cust, auto = car };

            foreach (var item in consumers)
            {
                Console.WriteLine($"Car info => {item.auto} \nOwner => {item.customer}");
                Console.WriteLine(new string('-', 32));
            }

            Console.ReadKey();
        }
    }
}
