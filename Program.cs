using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            int num = 0, i = 1;
            
            //Requesting data from the user
            Console.Write(" Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Exchanging bits
            for (int p=1; p<=32; p++)
            {
                if ((num & i) == 0)
                {
                    num = num | i;
                }
                else
                {
                    num = num & (~i);
                }

               i = i << 1;
            }

            Console.WriteLine(" The number that represents the bits exchanged is: {0}", num);
           

            Console.ReadKey();
        }
    }
}
