using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    internal class Person <T>
    {

        public T DisplayInformation(T value) { 
        return value;

        }
    }
}
