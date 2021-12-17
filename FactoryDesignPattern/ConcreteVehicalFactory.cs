using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ConcreteVehicalFactory:VehicalFactory
    {
        public override IFactory GetVehical(string vehical)
        {
            switch (vehical)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new Exception();
            }
        }
    }
}
