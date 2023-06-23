using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ReverseNumber
    {
        public void Checkreversenumber()
        {
            int num = 0;
            int remainder = 0;
            int reverse = 0;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());    
            while(num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num/10;
                
            }
            Console.WriteLine("After Reverse Number is =" + reverse);
        }


    }
}
