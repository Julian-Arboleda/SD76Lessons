using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Person
    {
        // the usual order, this is just for organization's sake
        // Fields
        //    Properties
        // Constructors
        // Method
        
        
        // Properties
        // - tend to be accessible from outside
        // - use PascalCase
        public string FirstName { get; set; }

        // Fields
        // - tend to be private, only apply to the class from within
        // - use and underscore _ and camelCase

        // Backing field - because it goes with a property
        // holds the value
        private string _lastName;
        // for outside access
        public string LastName
        {
            get { return "\"" +  _lastName + "\""; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get {
                // I can do other stuff before i return a value
                //(e.g. capitalize the names)
                int something = 5;
                int otherthing = 4 * something;
                Console.WriteLine(otherthing);
                return $"{FirstName} {LastName}";

            }
        }
          

        // prop tab tab is a shortcut
        public DateTime DateOfBirth { get; set; }


        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(totalAgeInYears);
                return yearsOfAge;
            }

        }



        public Vehicle Vehicle { get; set; }


        // Empty Constructor
        public Person() { }
       
        //Full Constructor (overload)
        // Overloaded means there are multiple versions

        public Person(string firstName, string lastName, DateTime dob, Vehicle vehicle)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Vehicle = vehicle;


        }
        
        
        
        
        
        
        //propfull tab tab = /dont forget _
        /* private int myVar;

        public int MyProperty
        {
            get { if (myVar % 2 == 0)
                {
                    return _myVar;
                }
                else
                {

                }
            set { myVar = value; } */


          
     }






    
}
