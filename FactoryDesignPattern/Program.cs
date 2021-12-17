using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicalFactory factory = new ConcreteVehicalFactory();
            IFactory scooter = factory.GetVehical("Scooter");
            scooter.Drive(20);
            IFactory bike = factory.GetVehical("Bike"); 
            bike.Drive(50);
        }
    }
}
