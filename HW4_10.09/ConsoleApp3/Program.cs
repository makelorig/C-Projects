using Zoo_Animals_project.Domain.Models;

Lion lion =  new Lion("lion", 10, Species.Birds, 10);

lion.Hunt();

Elephant elephant = new Elephant("elephant", 10, Species.Reptiles, 10);

elephant.Stand();

Monkey monkey = new Monkey("monkey", 10, Species.Mammal, true);
monkey.Climb();
Console.WriteLine("\n\n");

Zoo zoo = new Zoo();
zoo.SetMaxCapZoo(3);

zoo.AddAnimal(lion);
zoo.AddAnimal(elephant);
zoo.AddAnimal(monkey);
zoo.FeedAll();
zoo.SoundOff();

zoo.ZooInfo();
Console.WriteLine("\n\n");
zoo.animalFoundByType(Species.Mammal);
Console.WriteLine("\n\n");
Monkey mm = new Monkey("monkey", 10, Species.Mammal, true);
zoo.AddAnimal(mm);
zoo.AddAnimal(mm);
zoo.AddAnimal(mm);
zoo.AddAnimal(mm);




