using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        //fields
        private int wagonNumber = 0;
        private int wagonSize = 10;
        private List<Animal> animalInWagon = new List<Animal>();

        //properties
        public int WagonNumber { get { return wagonNumber; } set { } }
        public int WagonSize { get { return wagonSize; } set { } }
        public List<Animal> AnimalInWagon { get { return animalInWagon; } set { } }



        public Wagon(int wagonSize)
        {
            this.wagonSize = wagonSize;

        }



        public bool addAnimal(Animal animal)
        {



            if (checkCapacity(animal))
            {



                if (animalInWagon.Count == 0)
                {
                    animalInWagon.Add(animal);
                    wagonSize -= (int)animal.AnimalSizePublic;
                    return true;

                }
                else
                {

                    foreach (Animal checkAnimal in this.animalInWagon)
                    {

                        if (checkAnimal.AnimalSizePublic! <= animal.AnimalSizePublic && animal.AnimalTypePublic != Animal.AnimalType.Carnivore || checkAnimal.AnimalTypePublic != Animal.AnimalType.Carnivore && checkAnimal.AnimalSizePublic! >= animal.AnimalSizePublic)
                        {
                            animalInWagon.Add(animal);
                            wagonSize -= (int)animal.AnimalSizePublic;
                            return true;
                        }
                    }
                    return false;
                }
            }
            else { return false; }

       

        }


        public bool checkCapacity(Animal animal)
        {
            if (this.WagonSize - animal.AnimalSizePublic >= 0)
            {

                return true;
            }
            else
            {
                return false;
            }


        }


    }
}

        


    



