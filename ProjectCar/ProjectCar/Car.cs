using System;

namespace ProjectCar
{
    internal partial class Program
    {
        class Car 
        {
            private string name;

            public Car(string name)
            {
                this.name = name;
            }
                      
            public void Start()
            {
                Console.WriteLine("Car started");
            }

            public string GetName() 
            {
                return name;
            }


        }
    }
}
