using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static CircusTrein.Animal;

namespace CircusTrein
{
    public class Wagon
    {
        //fields
        
        private readonly List<Animal> animalInWagonList = new();
        private int _wagonSize = 10;

        //properties
        public int WagonSize { get { return _wagonSize; } }
        public IReadOnlyList<Animal> AnimalInWagonList { get { return animalInWagonList; } }


        public bool tryAddToWagon(Animal animal)
        {

            if (!checkCapacity(animal))
            {
                return false;
            }

            else
            {
                foreach (Animal animalInWagon in this.animalInWagonList)
                {
                    if (animal.canEatOtherAnimal(animalInWagon) || animal.willBeEaten(animalInWagon))
                    {
                        return false;
                       
                    }
                }
                
                animalInWagonList.Add(animal);
                _wagonSize -= (int)animal.currentSize;
                return true;
              

            }
        }


        public bool checkCapacity(Animal animal)
        {
            bool canFit = WagonSize - animal.currentSize >= 0 ? true : false;
            return canFit;
        }


    }
}








