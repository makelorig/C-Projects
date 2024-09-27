namespace Zoo_Animals_project.Domain.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Species Species { get; set; }

        public Animal(string name, int age, Species species) {
            Name = name;
            Age = age;
            Species = species;
        }
        
        public void Eat() {
            Console.WriteLine("Кушаю");
        }
        public void Sleep() {
            Console.WriteLine("zzzzzz");
        }
        public void Info()
        {
            Console.WriteLine($"Name: {Name}, Age:  {Age}, Species: {Species}");
        }
        public abstract void MakeSound();
        public Species GetSpecies()
        {
            return Species;
        }
    }

}
