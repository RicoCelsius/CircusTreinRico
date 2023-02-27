using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Herbivore : Animal
    {
        public Herbivore(Size animalSize) : base(animalSize)
        {
        }

        public override bool canEatOtherAnimal(Animal animalInWagon)
        {
            return false;
        }


    }
}
