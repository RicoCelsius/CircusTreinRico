using CircusTrein;
using System.Collections.Generic;
using Xunit;

namespace CircusTreinTests
{
    public class TrainTests
    {
        private readonly Animal smallHerbiObj = new Animal(Animal.Diet.Herbivore, Animal.Size.Small);
        private readonly Animal mediumHerbiObj = new Animal(Animal.Diet.Herbivore, Animal.Size.Medium);
        private readonly Animal bigHerbiObj = new Animal(Animal.Diet.Herbivore, Animal.Size.Big);
        private readonly Animal smallCarniObj = new Animal(Animal.Diet.Carnivore, Animal.Size.Small);
        private readonly Animal mediumCarniObj = new Animal(Animal.Diet.Carnivore, Animal.Size.Medium);
        private readonly Animal bigCarniObj = new Animal(Animal.Diet.Carnivore, Animal.Size.Big);


        private List<Animal> CreateScenario(int smallHerbi, int mediumHerbi, int bigHerbi, int smallCarni, int mediumCarni, int bigCarni)
        {
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < smallHerbi; i++)
            {
                animals.Add(smallHerbiObj);
            }

            for (int i = 0; i < mediumHerbi; i++)
            {
                animals.Add(mediumHerbiObj);
            }

            for (int i = 0; i < bigHerbi; i++)
            {
                animals.Add(bigHerbiObj);
            }

            for (int i = 0; i < smallCarni; i++)
            {
                animals.Add(smallCarniObj);
            }

            for (int i = 0; i < mediumCarni; i++)
            {
                animals.Add(mediumCarniObj);
            }

            for (int i = 0; i < bigCarni; i++)
            {
                animals.Add(bigCarniObj);
            }

            return animals;
        }




        [Theory]
        [InlineData("scenario0", 0, 0, 0, 0, 0, 0, 0)]
        [InlineData("scenario1",0, 3, 2, 1, 0, 0, 2)]
        [InlineData("scenario2",5, 2, 1, 1, 0, 0, 2)]
        [InlineData("scenario3",1, 1, 1, 1, 1, 1, 4)]
        [InlineData("scenario4",1, 5, 1, 2, 1, 1, 5)]
        [InlineData("scenario5",1, 1, 2, 1, 0, 0, 2)]
        [InlineData("scenario6", 0, 2, 3, 3, 0, 0, 3)]

        [InlineData("scenario7",0, 5, 6, 7, 3, 3, 13)]



        public void TestTryAddAnimalToTrain(string testName,int smallHerbi,int mediumHerbi,int bigHerbi, int smallCarni, int mediumCarni, int bigCarni, int expectedWagonCount)
        {
            // Arrange
            Train train = new Train();
            List<Animal> animals = CreateScenario(smallHerbi,mediumHerbi,bigHerbi,smallCarni,mediumCarni,bigCarni);

            // Act
            train.tryAddAnimalToTrain(animals);

            // Assert
            Assert.Equal(expectedWagonCount, train.getWagons().Count);
        }
    }
}
