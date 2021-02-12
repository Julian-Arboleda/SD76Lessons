using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Currency
{
    public interface ICurrency
    {
        // Dependency Injection - 'Interchangeable parts" code depends on an object being injected as a parameter from the outside
        string Name { get; }
        decimal Value { get; }
    }
}
