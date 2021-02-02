using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.People
{
    // Inheritance means we are extending another class
    // we are making another class that has the same properties, but we can add more
    public class Customer : User
    {
        private int _maxId = 0;
        public int CustomerNumber { get; set; }
        public Customer(string email) : base(email, "UserName") 
        {
            // Random random = new Random();
            // CustomerNumber = random.Next(0,999999);
            CustomerNumber = _maxId;
             _maxId++;




        }
    }
}
