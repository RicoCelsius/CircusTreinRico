using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();






        public void tryAddAnimalToTrain(List<Animal> animals)
        {
            animals = sortAnimals(animals);
            
            foreach (Animal animal in animals)
            {
                bool added = false;
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.tryAddToWagon(animal))
                    {
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    AddWagon(animal);
                    
                }

               
            }
         
        }

        public List<Animal> sortAnimals(List<Animal> unsortedAnimals)
        {
            List<Animal> sortedCarnivores = unsortedAnimals
                .Where(a => a is Carnivore) // Alleen carnivoren selecteren
                .OrderByDescending(a => ((Carnivore)a).currentSize) // Sorteren op grootte
                .ToList();

            List<Animal> sortedHerbivores = unsortedAnimals
                .Where(a => a is Herbivore) // Alleen herbivoren selecteren
                .OrderByDescending(a => ((Herbivore)a).currentSize) // Sorteren op grootte
                .ToList();

            List<Animal> sortedAnimals = sortedCarnivores.Concat(sortedHerbivores).ToList();

            return sortedAnimals;
        }


        public void AddWagon(Animal animal)
        {
            Wagon w = new();
            w.tryAddToWagon(animal);
            Wagons.Add(w);
        }

    }
}
