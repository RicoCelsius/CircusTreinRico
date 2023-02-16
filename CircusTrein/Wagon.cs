using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        //fields
        private int wagonSize = 10;
        private readonly List<Animal> animalInWagonList = new();

        //properties
        public int WagonSize { get { return wagonSize; } set { } }
        public List<Animal> AnimalInWagonList { get { return animalInWagonList; } set { } }




        public bool tryAddToWagon(Animal animal)
        {

            if (!checkCapacity(animal))
            {
                return false;
            }

            if (animalInWagonList.Count == 0)
            {
                animalInWagonList.Add(animal);
                wagonSize -= (int)animal.getSize();
                return true;
            }
            else
            {
                foreach (Animal animalInWagon in this.animalInWagonList)
                {

                    if (animalInWagon.getSize()! < animal.getSize() &&
                        animal.getDiet() != Animal.Diet.Carnivore ||
                        animalInWagon.getDiet() != Animal.Diet.Carnivore &&
                        animalInWagon.getSize()! >= animal.getSize())
                    {
                        animalInWagonList.Add(animal);
                        wagonSize -= (int)animal.getSize();
                        return true;
                    }
                }
                return false;

            }
        }


        public bool checkCapacity(Animal animal)
        {
            bool canFit = WagonSize - animal.getSize() >= 0 ? true : false;
            return canFit;
        }


    }
}








