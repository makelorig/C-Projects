namespace Zoo_Animals_project.Domain.Models
{
    public class Zoo {
        private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal) {
            _animals.Add(animal);
        }

        public void FeedAll() {
            foreach (Animal animal in _animals) {
                animal.Eat();
            }
        }

        public void SoundOff() {
            foreach(Animal animal in _animals) {
                animal.MakeSound();
            }
        }
    }
}
