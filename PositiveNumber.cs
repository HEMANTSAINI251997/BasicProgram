using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class PositiveNumber
    {
        public void Checkpositivenumber()
        {
            int num = 0;
            Console.WriteLine("ENTER THE NUMBER");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("NUMBER IS POSITIVE");
            }
            else if (num < 0)
            {
                Console.WriteLine("NUMBER IS NEGATIVE");

             }
            else
            {
                Console.WriteLine("NUMBER IS ZERO");
            }
        
        }   
    }
}
