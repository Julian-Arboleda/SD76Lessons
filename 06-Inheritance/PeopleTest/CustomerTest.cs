using _06_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance.PeopleTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomersAndUsers()
        {
            User user = new User("fake@email.com", "Username");
            Customer customer = new Customer("notReal@fakeEmal.biz");

           user.SetFirstName("Julian");
           user.SetLastName("Arboleda");

            customer.SetFirstName("Zuri");
            customer.SetLastName("Rojas");


            Console.WriteLine("User:");
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.ID);
            Console.WriteLine("Customer:");
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.Name);

         }
    }
}
