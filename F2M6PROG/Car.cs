using System;
using System.Collections.Generic;
using System.Text;

namespace F2M6PROG
{
    public enum CarTypes
    {
        Hatchback,
        Hybrid,
        Electric,
        Offroad,
        SUV,
        Sedan
    }

    public abstract class Car
    {
        public string Name { get; private set; }
        public string Engine { get; private set; }

        public Car(string name, string engine)
        {
            Name = name;
            Engine = engine;
        }
    }
}
