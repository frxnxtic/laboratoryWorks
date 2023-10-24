using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1.Abstract_Factory
{
    internal class DogFactory : AbstractAnimalFactory
    {
        public override Animal CreateAnimal(string animalType)
        {
            return new Dog();
        }
    }
}
