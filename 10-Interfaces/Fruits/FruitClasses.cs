using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public string Name => "Banana";
        // public string Name {get;} = "Banana";
        // => aka Arrow notation - super shorthand for returning a value like in a method that you can use in a few specific places

        public bool IsPeeled { get; private set; } = false;

        public string Peel() // Methods have to return a value or a error
        {
            IsPeeled = true;
            return "You peel the banana";
        }
    }

    public class Orange : IFruit
    {
        public bool IsPeeled { get; private set; }
        public string Name 
        {
            get
            {
                return "Orange";
            }
        }
        // public string Name => "Orange;
        // public string Name {get;} = "Orange"; lines 28 - 36 all acceptable answers
        public Orange(bool isPeeled) 
        {
            IsPeeled = isPeeled;

        }

        public string Peel()
        {
            if (IsPeeled)
            {
                // throw new Exception("It's already been peeled!");
                return "This orange has already been peeled!";
            }

            IsPeeled = true;
            return $"You peel the {GetType().Name}";
        }

        public string Squeeze()
        {
            return "You get orange juice!";
        }
    }

    public class Mandarin : Orange
    {
        // I don't have to define all those 
        public Mandarin(bool isPeeled) : base(isPeeled) { }
    }

    public class Grape : IFruit
    {
        // The getter always returns "Grape"
        public string Name => "Grape";
        // line 64 and 66, both property definitions work the same way
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            // throw new Exception("What are you, a toddler?");
            return "who the heck peels grapes?";
        }
    }

    public class Apple : IFruit
    {
        public string Name => "Apple";

        public bool IsPeeled { get; } = true;
        public bool IsRipe { get; }

        public string Peel()
        {
            return "You peel the apple";
        }
        
    }


}

    // CHALLENGE:

    // Create your own member of the IFruit interface, with its own unique implementation of Peel() 
    // and one each additional property and method.
    // Add it to the fruitBasket List in the Test Method