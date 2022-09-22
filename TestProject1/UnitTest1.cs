using NUnit.Framework;
using CircusTrein;

namespace TestProject1
{
    public class Tests
    {


        [Test]
        public void testMaximumCapacity()
        {
            //setup
            Wagon w = new Wagon(3); // Create a wagon with capacity 5.
            Animal animal = new Animal(Animal.AnimalName.Leeuw,Animal.AnimalSize.Big); // Create an animal that has a larger capacity than 5
            //act
            w.addAnimal(animal); //Try to add animal to list
            //assert
            Assert.IsEmpty(w.AnimalInWagon); //Animal cant be added to the list because its size is too big.
        }

        [Test]
        public void testCarnivoreEatHerbivore()
        {
            //setup
            Wagon w = new Wagon(10);
            Animal animal = new Animal(Animal.AnimalName.Olifant, Animal.AnimalSize.Small);
            Animal animal2 = new Animal(Animal.AnimalName.Leeuw, Animal.AnimalSize.Big);

            //act
            w.addAnimal(animal);
            w.addAnimal(animal2);
 
            //assert
            CollectionAssert.DoesNotContain(w.AnimalInWagon,animal2); //cant add animal2 because it will eat animal
        }

        [Test]

        public void testAddAnimal()
        {
            //setup 
            Wagon w = new Wagon(10);
            Animal carnivore = new Animal(Animal.AnimalName.Leeuw, Animal.AnimalSize.Big);
            //act
            bool check = w.addAnimal(carnivore);
        
            //assert
            Assert.IsTrue(check);
        }



        [Test]
        public void testCapacity()
        {
            //setup
            Wagon w = new Wagon(10);
            Animal animal = new Animal(Animal.AnimalName.Olifant, Animal.AnimalSize.Big);
            //act
            w.addAnimal(animal);
            //assert
            Assert.AreEqual(5, w.WagonSize);

        }

        [Test]
        public void testMultipleAnimals()
        {
            //setup
            Wagon w = new Wagon(10);
            Animal animal = new Animal(Animal.AnimalName.Olifant, Animal.AnimalSize.Medium);
            Animal animal2 = new Animal(Animal.AnimalName.Olifant, Animal.AnimalSize.Medium);
            Animal animal3 = new Animal(Animal.AnimalName.Leeuw, Animal.AnimalSize.Medium);

            //act
            w.addAnimal(animal);
            w.addAnimal(animal2);
            w.addAnimal(animal3);

            //assert
            Assert.AreEqual(1, w.WagonSize); // 10 - 3 - 3 - 3 = 1
            

        }
    }
}