using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Fract a = new Fract(1, 2);
            Fract b = new Fract(1, 3);

            Fract c = a + b;

            int x = (int)a;

            
        }
    }
}
