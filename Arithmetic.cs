using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Arithmetic
    {
        public void Checkarithmetic()
        {
            int a = 0; int b=0;
            int sum=0; int sub=0; int mul = 0; int div=0; int mod = 0;
            Console.WriteLine("Enter First Number");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("ADD =" + sum);
            sub = a - b;
            Console.WriteLine("Subtract ="+ sub);
            mul = a * b;
            Console.WriteLine("Multiply =" + mul);
            div = a / b;
            Console.WriteLine("Division =" + div);
            mod = a % b;
            Console.WriteLine("Modulas ="+ mod);
        }
    }
}
