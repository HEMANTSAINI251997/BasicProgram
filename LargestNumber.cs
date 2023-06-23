using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LargestNumber
    {
        public void Checklargestnumber()
        {


            int a = 0;
            int b = 0;
            Console.WriteLine("Enter First Number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b=Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The Largest Number is =" + a);
            }
            else if (b > a)
            {
                Console.WriteLine("The Largest Number is =" + b);
            }
            else
            { 
                Console.WriteLine("Both are equals");
            }
        }

    }
}
