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

        public int WagonSize { get; private set; } = 10;
        private List<Animal> animalInWagonList { get; set; } = new();


        public IReadOnlyList<Animal> GetAnimalsInWagon()
        {
            return animalInWagonList.AsReadOnly();
        }

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
                addAnimalToWagon(animal);
                WagonSize -= (int)animal.currentSize;
                return true;
            }
        }

        internal void addAnimalToWagon(Animal animal)
        {
            animalInWagonList.Add(animal);
        }



        private bool checkCapacity(Animal animal)
        {
            return WagonSize - animal.currentSize >= 0 ? true : false;
        }
    }
}








