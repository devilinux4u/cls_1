using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_1
{
    public class PolymorphismExample
    {

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }

        public void Add(String s1, String s2)
        {
            Console.WriteLine(s1 + ' ' + s2);
        }
    }
}
