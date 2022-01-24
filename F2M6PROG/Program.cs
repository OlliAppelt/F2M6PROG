using System;
using System.Collections.Generic;

namespace F2M6PROG
{
    class Program
    {   
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Garage hatchback = new Car("Hatchback", CarTypes.Hatchback);
            Garage hatchback = new Car("Hatchback", CarTypes.Hatchback);
            Garage hatchback = new Car("Hatchback", CarTypes.Hatchback);

            foreach(Car c in garage.GetCar())
            {
                
            }
               
        }
    }
}
