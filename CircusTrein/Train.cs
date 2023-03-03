using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {

        private List<Wagon> wagons = new();


        public IReadOnlyList<Wagon> GetWagons()
        {
            return wagons.AsReadOnly();
        }


        public void AddAnimalToTrain(List<Animal> animals)
        {
            animals = sortAnimals(animals);
            
            foreach (Animal animal in animals)
            {
                bool added = false;
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.tryAddToWagon(animal))
                    {
                        added = true;
                        break;
                    }
                }
                if (!added)
                {
                    addNewWagon(animal);
                }
            }
        }
        private List<Animal> sortAnimals(List<Animal> unsortedAnimals)
        {
            List<Animal> sortedAnimals = unsortedAnimals
                .OrderByDescending(a => a is Carnivore) // Sort carnivores 
                .ThenByDescending(a => a is Herbivore) // Sort herbivores
                .ThenByDescending(a => a.currentSize) //Sort on size.
                .ToList();

            return sortedAnimals;
        }



        private void addNewWagon(Animal animal)
        {
            Wagon newWagon = new();
            newWagon.addAnimalToWagon(animal);
            wagons.Add(newWagon);
            if (!wagons.Contains(newWagon)){
                throw new InvalidOperationException("Unable to add wagon to list of wagons.");
            }
;        }

    }
}
