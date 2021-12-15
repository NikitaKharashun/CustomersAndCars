using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersCar.Elements
{
    class Car
    {
        public string Model { get; private set; }
        public string Producer { get; private set; }
        public int ProductionYear { get; private set; }
        public string Paint { get; private set; }

        public Car(string model, string producer, int productionYear, string paint)
        {
            Model = model;
            Producer = producer;
            ProductionYear = productionYear;
            Paint = paint;
        }


        public override string ToString() => $"Model: {Model} \nProducer: {Producer} \nProductionYear: {ProductionYear} \nPaint:{Paint}";
        public static List<Car> CarsList()
        {
            List<Car> cars = new List<Car>()
        {
            new Car("911", "Porshe", 2011, "Black"),
            new Car("570S", "McLaren", 2015, "Orange"),
            new Car("XC90", "Volvo", 2008, "White")
        };
            return cars;
        }
    }
}
