using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    public interface IFruit // A interface is a template for your class, like an outlet in your house the interface is your outlet and you can apply appliances to your interface
    {
        string Name { get; } // you don't declare access modifiers for interface properties
        bool IsPeeled { get; }
        string Peel();
    }
}
