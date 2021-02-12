using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces.Fruits
{
    [TestClass]
    public class IFruitTest
    {
        [TestMethod]
        public void FruitTest()
        {
           // IFruit ifruit = new IFruit(); - can't do this because it's an interface
            Banana banana = new Banana();
            Orange orange = new Orange(true);
            orange.Peel();
            banana.Peel();
            Grape grape = new Grape();
            Mandarin mandarin = new Mandarin(false);
            Apple apple = new Apple();

            List<IFruit> fruitBasket = new List<IFruit>();

            fruitBasket.Add(banana);
            fruitBasket.Add(grape);
            fruitBasket.Add(orange);
            fruitBasket.Add(mandarin);
            fruitBasket.Add(apple);

            foreach (IFruit fruit in fruitBasket)
            {
                if(fruit.Name != "Grape")
                {
                    Console.WriteLine(fruit.Peel()); ;
                }
            }
        }
    }
}
