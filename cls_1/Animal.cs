using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_1
{
    public class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("Animal is moving");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal { 
        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

}
