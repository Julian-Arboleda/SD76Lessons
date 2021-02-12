using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.KomodoIns
{
    public class Sedan : IKomodo
    {
        public string Make => "Honda";

        public string Model => "Accord";

        public string Color => "Green";

        public bool IsOn => throw new NotImplementedException();

        public string ToDrive()
        {
            return "You are driving the car.";
        }

        public string ToStart()
        {
            return "You've started the vehicle";
        }

        public string ToTurnOff()
        {
            throw new NotImplementedException();
        }
    }



    public class SUV : IKomodo
    {
        public string Make => "Cadillac";

        public string Model => "Escalade";

        public string Color => "Black";

        public bool IsOn => throw new NotImplementedException();

        public string ToDrive()
        {
            throw new NotImplementedException();
        }

        public string ToStart()
        {
            throw new NotImplementedException();
        }

        public string ToTurnOff()
        {
            throw new NotImplementedException();
        }
    }

    public class Van : IKomodo
    {
        public string Make => "Dodge";

        public string Model => "Caravan";

        public string Color => "White";

        public bool IsOn => throw new NotImplementedException();

        public string ToDrive()
        {
            throw new NotImplementedException();
        }

        public string ToStart()
        {
            throw new NotImplementedException();
        }

        public string ToTurnOff()
        {
            throw new NotImplementedException();
        }
    }

    public class Motorcyles : IKomodo
    {
        public string Make =>"Ducati";

        public string Model => "950 SP";

        public string Color => "Red";

        public bool IsOn => throw new NotImplementedException();

        public string ToDrive()
        {
            throw new NotImplementedException();
        }

        public string ToStart()
        {
            throw new NotImplementedException();
        }

        public string ToTurnOff()
        {
            throw new NotImplementedException();
        }
    }
}
