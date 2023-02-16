using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {


        private List<Wagon> _wagons = new List<Wagon>();
        private List<Wagon> Wagons { get { return _wagons; } }




        public List<Wagon> getWagons()
        {
            return Wagons;
        }

        public void tryAddAnimalToTrain(List<Animal> animals)
        {
       
            
            foreach (Animal animal in sortAnimals(animals))
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
                    added = true;
                }

               
            }
         
        }

        public List<Animal> sortAnimals(List<Animal> animals)
        {
            

            // Sort animals by size
            animals.Sort((a1, a2) => a2.getSize().CompareTo(a1.getSize()));

            // Sort animals by diet
            animals.Sort((a1, a2) => a2.getDiet().CompareTo(a1.getDiet()));

            return animals;


        }



    public void AddWagon(Animal animal)
        {
            Wagon w = new();
            w.tryAddToWagon(animal);
            Wagons.Add(w);
        }

    }
}
