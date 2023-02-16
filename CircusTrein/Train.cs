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
                    added = true;
                }

               
            }
         
        }




        public void AddWagon(Animal animal)
        {
            Wagon w = new();
            w.tryAddToWagon(animal);
            Wagons.Add(w);
        }

    }
}
