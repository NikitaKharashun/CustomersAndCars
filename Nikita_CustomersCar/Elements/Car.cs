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
        public List<Car> Cars { get; private set; }

        public Car(string model, string producer, int productionYear, string paint)
        {
            Model = model;
            Producer = producer;
            ProductionYear = productionYear;
            Paint = paint;
        }

        public override string ToString() => $"Model: {Model} \nProducer: {Producer} \nProductionYear: {ProductionYear} \nPaint:{Paint}";
        public void Add(List<Car> cars, Car auto) => cars.Add(auto);
    }
}
