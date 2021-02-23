using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goldquiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)

            {

                for (int x = 0; x <= 12; x++)

                {

                    Console.WriteLine("{0} x {1} = {2}", i, x, i * x);

                }

                Console.WriteLine(". . .");

            }

        }
    }
}
