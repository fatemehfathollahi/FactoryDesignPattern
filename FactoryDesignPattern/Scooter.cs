using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("drive " + miles + " for scooter");
        }
    }
}
