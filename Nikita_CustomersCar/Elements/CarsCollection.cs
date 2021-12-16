using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_CustomersCar.Elements
{
    class CarsCollection
    {
        public List<Car> Cars { get; private set; }

        public CarsCollection() => Cars = new List<Car>();

        public void Add(Car auto) => Cars.Add(auto);
    }
}
