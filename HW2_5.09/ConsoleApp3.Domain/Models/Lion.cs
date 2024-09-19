namespace Zoo_Animals_project.Domain.Models
{
    public class Lion : Animal {
        private int _prideSize;

        public Lion(string name, int age, Species species, int prideSize) : base(name, age, species) {
            _prideSize = prideSize;
        }

        public void Hunt() {
            Console.WriteLine("Охочусь");
        }

        public override void MakeSound() {
            Console.WriteLine("Рычу");
        }
    }
}
