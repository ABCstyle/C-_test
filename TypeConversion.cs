using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            double d = 1234.56;
            int i;

            i = (int)d;
            Console.WriteLine(i);

            Console.WriteLine("-------");

            int a = 1234;
            float b = 23.005f;
            double c = 4321.56;
            bool e = true;

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(e.ToString());

            Console.ReadKey();
        }
    }
}
