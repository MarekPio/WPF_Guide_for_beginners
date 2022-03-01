using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingListToClass
{
    class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car>()
            { 
                new Car(){Owner="Mike", Type=CarType.Hatchbak, Brand=CarBrand.Audi},
                new Car(){Owner="Emma", Type=CarType.Sedan, Brand=CarBrand.Tesla},
                new Car(){Owner="Jon", Type=CarType.SUV, Brand=CarBrand.BMW}
            }.ToList();
        }
    }
}
