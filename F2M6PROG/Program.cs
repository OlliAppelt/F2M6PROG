using System;
using System.Collections.Generic;

namespace F2M6PROG
{
    class Program
    {   
        static void Main(string[] args)
        {
            Garage _garage = new Garage();

            Car aCar = new Car("Lancia");
            Car aCar1 = new Car("Aston Martin");

            _garage.AddCar(aCar);
            _garage.AddCar(aCar1);

            foreach(Car c in _garage.GetCar())
            {
                Console.WriteLine(c.GetName());
            }
               
        }
    }
}
