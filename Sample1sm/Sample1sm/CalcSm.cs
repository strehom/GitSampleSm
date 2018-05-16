using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1sm
{
    class CalcSm
    {
        public void add()
        {
            Console.WriteLine("This is the Add method.");
        }

        public void div()
        {
            int a = 2;
            int b = 3;
            Console.WriteLine("This is the Div method: " + a+b);
        }

        public void divB()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i * 2);
            }
        }
    }
}
