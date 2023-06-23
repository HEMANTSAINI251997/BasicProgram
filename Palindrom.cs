using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Palindrom
    {
        public void Checkpalindrom()
        {
            int num = 0;
            int remainder = 0;
            int reverse = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int number = num;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;

            }
            if ( num == reverse)
            {
                Console.WriteLine("Number is Palindrom");
            }
            else
            {
                Console.WriteLine("Number is Not Palindrom");
            }
        }
    }
}
