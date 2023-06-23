using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class AsciiValue
    {
        public void Checkasciivalue()
        {
            for (int i = 0; i <= 127; i++)
            {
                char c = (char)i;
                Console.WriteLine("ASCII value: " + i + ", Character: " + c);
            }

        }
    }
}
