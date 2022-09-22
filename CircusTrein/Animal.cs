using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein


{


    public class Animal
    {
        public enum AnimalType { Carnivore, Herbivore }
        private AnimalType animalType;
        public AnimalType AnimalTypePublic { get { return animalType; } }

        public enum AnimalName {Hond,Leeuw,Olifant,Cavia}
        private AnimalName animalName;
        public AnimalName AnimalNamePublic { get { return animalName; } }

       
        public enum AnimalSize { Big = 5, Medium = 3, Small = 1 }
        private AnimalSize animalSize;
        public AnimalSize AnimalSizePublic { get { return animalSize; } }  

     

       

        

        public Animal(AnimalName animalName, AnimalSize animalSize)
        {
            this.animalName = animalName;
            this.animalSize = animalSize;

            if(animalName == AnimalName.Hond || animalName == AnimalName.Leeuw)
            {
                this.animalType = AnimalType.Carnivore;
            }
            else
            {
                this.animalType = AnimalType.Herbivore;
            }
    
            
           

            
        }





    }
}
