using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein


{


    public class Animal
    {
        public enum Diet { Carnivore, Herbivore }
        public enum Size { Big = 5, Medium = 3, Small = 1 }





        private Diet _diet;
        private Size _size;

        public Diet getDiet()
        {
            return _diet;
        }

        public Size getSize()
        {
            return _size;
        }

        public Animal(Diet animalDiet, Size animalSize)
        {
            this._diet = animalDiet;
            this._size = animalSize;
        }

        public bool canEatOtherAnimal(Animal target)
        {
            if(this.getDiet() == Animal.Diet.Carnivore && target.getSize() <= this.getSize())
            {
                return true;
            }
            return false;
        }

        public bool willBeEaten(Animal target)
        {
            if(target.getSize() <= this.getSize() && this.getDiet() == Animal.Diet.Carnivore)
            {
                return true;
            }
            return false;
        }
    }
}
