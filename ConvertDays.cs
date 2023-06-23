using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ConvertDays
    {
        public void CountDays()
        {
            Console.WriteLine("Enter The Number Of Days");
            int num=Convert.ToInt32(Console.ReadLine());
            int year = 0;
            int week = 0;
            int days = 0;
            int rem = 0;

            year = num / 365;
            rem = num % 365;
            week = rem / 7;
            days = rem % 7;
            Console.WriteLine("years =" + year );
            Console.WriteLine("Weeks =" + week );
            Console.WriteLine("Days =" + days );


        }
    }
}
