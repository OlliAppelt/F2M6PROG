using System;
using System.Collections.Generic;

namespace F2M6PROG
{
    class Program
    {   
        static void Main(string[] args)
        {

            Garage garage = new Garage();

            Car hatchback = new AllCars("Hatchback", CarBrands.Subaru);
            Car hybrid = new AllCars("Hybrid", CarBrands.Toyota);
            Car offroad = new AllCars("Offroad", CarBrands.Ford);

            garage.AddCar(hatchback);
            garage.AddCar(hybrid);
            garage.AddCar(offroad);

            Console.WriteLine("What car type would you like to see?");
            string Input = Console.ReadLine();

            foreach (Car c in garage.GetCar())
            {
                if (Input == c.Name)
                    {
                        Console.WriteLine(c.Brand);
                    }
                else
                    {
                        Console.WriteLine("Try again");
                    }
                }
            }
        }
    }
