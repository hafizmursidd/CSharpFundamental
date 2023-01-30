using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic.Interface
{
    internal interface IVehicle <T>
    {

        T GetColor(T Color);

        public void InfoVehicle();
    }

    class Car<T> : IVehicle<T>
    {
        public T GetColor(T Color)
        {
            return Color;
        }

        public void InfoVehicle()
        {
            Console.WriteLine($"This is Car");
        }
    }
}
