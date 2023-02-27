using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein


{


    public abstract class Animal
    {
       
        public enum Size { Big = 5, Medium = 3, Small = 1 }
        public Size currentSize { get; set; }




        public Animal(Size animalSize)
        {
            this.currentSize = animalSize;
        }

        abstract public bool canEatOtherAnimal(Animal animalInWagon);


        public bool willBeEaten(Animal animalInWagon)
        {
            if (animalInWagon.canEatOtherAnimal(this))
            {
                return true;
            }
            return false;
        }

    }
}
