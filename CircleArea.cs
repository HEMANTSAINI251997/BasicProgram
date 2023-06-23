using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class CircleArea
    {
        public void CircleArea_()
        {
            int radius = 0;
            double area = 0;
            Console.WriteLine("Enter the Radius");
            radius=Convert.ToInt32(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("AREA OF CIRCLE =" + area);
        }
    }
}
