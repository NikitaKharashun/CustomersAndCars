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
            var consumers = new CustomersCollection();

            consumers.Add(new Customer("Jack", 457657, "XC90"));
            consumers.Add(new Customer("Jones", 5677897, "570S"));
            consumers.Add(new Customer("Carl", 4564678, "911"));


            var autos = new CarsCollection();

            autos.Add(new Car("911", "Porshe", 2011, "Black"));
            autos.Add(new Car("570S", "McLaren", 2015, "Orange"));
            autos.Add(new Car("XC90", "Volvo", 2008, "White"));

            var customers = from customer in consumers.Customers join car in autos.Cars on customer.CarModel equals car.Model select new { customer = customer, auto = car };

            foreach (var item in customers)
            {
                Console.WriteLine($"Car info => {item.auto} \nOwner => {item.customer}");
                Console.WriteLine(new string('-', 32));
            }

            Console.ReadKey();
        }
    }
}
