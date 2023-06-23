using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Swap
    {
        public void SwapVariable()
        {
            int a=0; int b = 0; int temp = 0;
            Console.WriteLine("Enter First Number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b= Convert.ToInt32(Console.ReadLine());
            temp = a;
            a = b;
            b=temp;
            Console.WriteLine("After Swaping First Number =" + a);
            Console.WriteLine("After Swaping Second Number =" + b);

        }
    }
}
