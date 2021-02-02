using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Inheritance.People
{
    public class User
    {   // Fields
        private string _firstName;
        private string _lastName;

        public string ID { get; }

        public string PhoneNumber { get; set; }
        public string Email { get; }



        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}"; // string interpolation $ indicates there's gonna be variables eg _firstname _lastName
                if (!string.IsNullOrWhiteSpace(fullName)) //IsNullIsEmpty = doesnt count spaces, whitespace does
                {
                    return fullName;
                }

                return "Unnamed"; // you can use else but in this example you dont need to

                // Same thing, using ternary expression
                //  return !string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed";




                // if its sunday isWeekend = true
                // If it's Saturday, isWeekend = true
                // if !isWeekend, work!! ! = not

            }
        }
        // Constructor
        public User(string email, string userName) // with constructor you dont need return type
        {
            Email = email;
            // setter not need because this is the constructor
            ID = GenerateId();

            // Create a method that will generate a RANDOM ID
            // 16 UPPERCASE letters and numbers
            // Cannot include the letter 'X'
            // Also cannot include vowels // A I O U E
            // Must include at least one number

        }


        public void SetFirstName(string name)
        {
            // if name is profanity, reject etc. e.g
            _firstName = name;
            // Can't set ID here because there is no setter
            // ID = "safiuwe";
        }

        // although both variables use "name" it's in two different (scopes) method (body)?
        public void SetLastName(string name)
        {
            _lastName = name;


        
        // Static - This applies to the WHOLE CLASS, not any particular member

            Console.WriteLine("d");
            // Convert.ToInt32();


            // instance methods apply to a PARTICULAR INSTANCE of a class

            // have to be called from a member of class
            // examples
            Random random = new Random();
            random.Next(0, 5);


            // user.SetLastName()

        
        }
        
        
        
        
        
        // So no properties!
        public static string GenerateId()
        {
            char[] letters = new char[] { 'D', 'B', 'C', 'F', 'G', '1', '2', '3', '4', '5' };

            string id = "";
            Random random = new Random();
            bool hasNumber = false;
            for (int i = 0; i < 16; i++)
            {
                int sleepCount = random.Next(1, 5);
                Thread.Sleep(sleepCount);
                // RandomNumberGenerator rng = RandomNumberGenerator.Create(id);
                int randomNum = random.Next(0, letters.Length);
                if (i ==15 && !hasNumber)
                {
                    randomNum = random.Next(5, letters.Length);
                }
                if (randomNum >= 5)
                {
                    hasNumber = true;
                }
                id += letters[randomNum];
            }
            return id;
                   


           

            // Pseudocode-

            // start with an empty string
            // Create a random generator
            // Create a flag to tell where or not a number has been selected
            // go from positons 1 through 16
            //      pick a random letter from the array
            //      add that letter to the empty string
            // while the id does not contain a number
            // return the string

            // ex tip everything in c# can be .ToString
        }




        // Create a method that will generate a RANDOM ID
        // 16 UPPERCASE letters and numbers
        // Cannot include the letter 'X'
        // Also cannot include vowels // A I O U E
        // Must include at least one num






    }
}
