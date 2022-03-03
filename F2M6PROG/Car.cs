using System;
using System.Collections.Generic;
using System.Text;

namespace F2M6PROG
{
    public enum CarBrands
    {
        Subaru,
        Toyota,
        Ford,
    }

    public abstract class Car
    {
        public string Name { get; private set; }
        public CarBrands Brand { get; private set; }

        protected Car(string name, CarBrands types)
        {
            Name = name;
            Brand = types;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
