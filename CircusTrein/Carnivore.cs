using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Carnivore : Animal


    {


        public Carnivore(Size animalSize) : base(animalSize)
        {
        }

        public override bool canEatOtherAnimal(Animal animalInWagon)
        {
            if(this.currentSize >= animalInWagon.currentSize)
            {
                return true;
            }
            return false;
        }


    }
}
