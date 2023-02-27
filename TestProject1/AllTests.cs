using NUnit.Framework;
using CircusTrein;
using System.Collections.Generic;

namespace CircusTrein_Tests
{


    public class AllTests
    {




        [Test]
        public void TestMaximumCapacity()
        {
            //setup
            Wagon w = new(); // Create a wagon with capacity 5.
            Animal animal = new(Animal.Diet.Carnivore, Animal.Size.Big); // Create an animal that has a larger capacity than 5
            //act
            w.tryAddToWagon(animal); //Try to add animal to list
            //assert
            Assert.IsEmpty(w.AnimalInWagonList); //Animal cant be added to the list because its size is too big.
        }

        [Test]
        public void TestCarnivoreEatHerbivore()
        {
            //setup
            Wagon w = new();
            Animal animal = new(Animal.Diet.Herbivore, Animal.Size.Small);
            Animal animal2 = new(Animal.Diet.Carnivore, Animal.Size.Big);

            //act
            w.tryAddToWagon(animal);
            w.tryAddToWagon(animal2);

            //assert
            CollectionAssert.DoesNotContain(w.AnimalInWagonList, animal2); //cant add animal2 because it will eat animal
        }

        [Test]

        public void TestAddAnimal()
        {
            //setup 
            Wagon w = new();
            Animal carnivore = new(Animal.Diet.Carnivore, Animal.Size.Big);
            //act
            bool check = w.tryAddToWagon(carnivore);

            //assert
            Assert.IsTrue(check);
        }



        [Test]
        public void TestCapacity()
        {
            //setup
            Wagon w = new();
            Animal animal = new(Animal.Diet.Herbivore, Animal.Size.Big);
            //act
            w.tryAddToWagon(animal);
            //assert
            Assert.AreEqual(5, w.WagonSize);

        }

        [Test]
        public void TestMultipleAnimals()
        {
            //setup

            Train t = new();
           
            Animal animal = new(Animal.Diet.Herbivore, Animal.Size.Medium);
            Animal animal2 = new(Animal.Diet.Herbivore, Animal.Size.Medium);
            Animal animal3 = new(Animal.Diet.Carnivore, Animal.Size.Medium);
            List<Animal> animals = new List<Animal>();
            animals.Add(animal);
            animals.Add(animal2);
            animals.Add(animal3);


            //act
            t.tryAddAnimalToTrain(animals);


            //assert
            Assert.AreEqual(1, t.getWagons()); // 10 - 3 - 3 - 3 = 1


        }



        [Test]
        public void TestAddingAnimals()
        {
            //setup
            Train t = new();


            //act
            /*t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);*/
            //assert
            Assert.AreEqual(2, t.getWagons().Count);
        }

        [Test]
        public void TestAddingAnimalsJPScenario1()
        {
            //setup
            Train t = new();


            //act
            
            /*t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);*/
            //assert
            Assert.AreEqual(2, t.getWagons().Count);
        }

        [Test]
        public void TestAddingAnimalsJPScenario2()
        {
            //setup
            Train t = new();



            //act
            //Scenario 1
            /*1 klein
            3 medium, 2 groot
            2*/


            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);*/





            //assert
            Assert.AreEqual(2, t.getWagons().Count);
        }


        [Test]
        public void TestAddingAnimalsJPScenario3()
        {

            Train t = new();
            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Big);

            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);*/

            Assert.AreEqual(4, t.getWagons().Count);
        }


        [Test]
        public void TestAddingAnimalsJPScenario4()
        {

            Train t = new();




            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Big);

            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
           
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);*/




            Assert.AreEqual(5, t.getWagons().Count);
        }

        [Test]
        public void TestAddingAnimalsJPScenario5()
        {

            Train t = new();
            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);


            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);*/

            Assert.AreEqual(2, t.getWagons().Count);
        }


        [Test]
        public void TestAddingAnimalsJPScenario6()
        {

            Train t = new();
            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);

            //  3 wagons met ieder 1 carnivoor van 1 punt

            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);


            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);*/

            Assert.AreEqual(3, t.getWagons().Count);
        }

        [Test]
        public void TestAddingAnimalsJPScenario7()
        {

            Train t = new();
            /*t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Small);

            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Medium);

            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Carnivore, Animal.Size.Big);*/


            // 7 wagon, ieder 1 punt, allemaal vleesters

           /* t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Medium);

            //1 wagon van 9 punten met 3 planteneters 


            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);
            t.tryAddAnimalToTrain(Animal.Diet.Herbivore, Animal.Size.Big);*/

            //1 wagon 2 met grote planteneters en 1 wagon met 1 grote planteneter

            //totaal: 4 wagons



            Assert.AreEqual(13, t.getWagons().Count);
        }



    }
}