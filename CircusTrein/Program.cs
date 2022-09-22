// See https://aka.ms/new-console-template for more information



using CircusTrein;

Animal a = new Animal(Animal.AnimalName.Cavia, Animal.AnimalSize.Big);
Animal b = new Animal(Animal.AnimalName.Leeuw, Animal.AnimalSize.Small);
Console.WriteLine(a.AnimalTypePublic);

Wagon w = new Wagon(10);
w.addAnimal(a);
w.addAnimal(b);
