using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1.Abstract_Factory
{
    internal abstract class AbstractAnimalFactory
    {
        public abstract Animal CreateAnimal(string animalType);
    }
}
