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

           var consumers = from cons in Customer.CustomersList() join car in Car.CarsList() on cons.CarModel equals car.Model select new { customer = cons, auto = car };

            foreach (var item in consumers)
            {
                Console.WriteLine($"{item.auto} \nOwner => {item.customer}");
                Console.WriteLine(new string('-', 32));
            }

            Console.ReadKey();
        }
    }
}
