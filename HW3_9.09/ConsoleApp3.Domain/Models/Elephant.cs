namespace Zoo_Animals_project.Domain.Models
{
    public class Elephant : Animal {
        private int _trunkLength;

        public Elephant(string name, int age, Species species, int trunkLength) : base(name, age, species) {
            _trunkLength = trunkLength;
        }


        public void Stand() {
            Console.WriteLine("Стою");
        }

        public override void MakeSound() {
            Console.WriteLine("Трубю");
        }
    }
}
