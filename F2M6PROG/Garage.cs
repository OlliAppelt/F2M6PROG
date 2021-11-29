using System;
using System.Collections.Generic;
using System.Text;

namespace F2M6PROG
{
    class Garage
    {
        private List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car aCar)
        {
            cars.Add(aCar);
        }

        public List<Car> GetCar()
        {
            return cars;
        }

    }
}
