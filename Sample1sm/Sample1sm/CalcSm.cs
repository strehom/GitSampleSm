using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1sm
{
    class CalcSm : ICalcSm
    {
        public void add()
        {
            Console.WriteLine("add");
        }

        public void div()
        {
            int a = 2;
            int b = 3;
            Console.WriteLine("This is the Div method: " + a + b);
        }

        public void divB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is the DivB method: " + i * 2);
            }
        }

        public void divD()
        {
            Console.WriteLine("This is the DivD method.");
        }

        public void mult()
        {
            Console.WriteLine("This is the Mult method.");
        }
    }
}
