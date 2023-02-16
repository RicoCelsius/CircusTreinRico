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
    }
}
