using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinTests
{
    public class WagonTests
    {

        [Theory]

        [InlineData(9, Animal.Size.Small)]
        [InlineData(7, Animal.Size.Medium)]
        [InlineData(5, Animal.Size.Big)]



        public void TestWagonCapacity(int expected, Animal.Size carniSize)
        {
            // Arrange

            Wagon testWagon = new();
            Carnivore carni = new Carnivore(carniSize);

            // Act
            
            testWagon.tryAddToWagon(carni);

            // Assert
            Assert.Equal(expected, testWagon.WagonSize);
        }


        [Theory]

        [InlineData(Animal.Size.Medium, Animal.Size.Small,false)]
        [InlineData(Animal.Size.Small, Animal.Size.Medium, true)]
        [InlineData(Animal.Size.Big, Animal.Size.Small, false)]

        public void TryAddToWagon_AddsCarnivoreAnimalWithHerbivore(Animal.Size carniSize, Animal.Size herbiSize, bool expected)
        {
            //Arrange
            Wagon testWagon = new Wagon();
            Animal animal1 = new Herbivore(herbiSize);
            Animal animal2 = new Carnivore(carniSize);

            testWagon.tryAddToWagon(animal1);

            //Act
            var result = testWagon.tryAddToWagon(animal2);

            //Assert
    
            Assert.Equal(expected, result);
   
        }

        [Fact]


        public void TestWagonContainsAnimal()
        {
            // Arrange

            Wagon testWagon = new();
            Carnivore carni = new Carnivore(Animal.Size.Medium);

            // Act

            testWagon.tryAddToWagon(carni);

            // Assert
            Assert.Equal(carni, testWagon.GetAnimalsInWagon()[0]);
        }

    }
}
