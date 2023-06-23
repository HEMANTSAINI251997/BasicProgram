using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class EvenOdd
    {
        public void CheckEvenOdd()
        {
            int num = 0;
            Console.WriteLine("Enter The Number");
            num=Convert.ToInt32(Console.ReadLine());   
            if(num%2 == 0)
            {
                Console.WriteLine("NUMBER IS EVEN");
            }
            else
            {
                Console.WriteLine("\n"+"NUMBER IS ODD"+"\n");
            }
        }
    }
}
