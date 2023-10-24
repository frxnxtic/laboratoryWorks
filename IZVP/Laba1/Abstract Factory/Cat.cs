using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1.Abstract_Factory
{
    internal class Cat : Animal
    {
        public override void Speak()
        {
            System.Console.WriteLine("Meow!");
        }
    }
}
