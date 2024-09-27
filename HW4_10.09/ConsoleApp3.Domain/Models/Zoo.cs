namespace Zoo_Animals_project.Domain.Models
{
    public class Zoo {
        private List<Animal> _animals = new List<Animal>();
        private int _maxZooCap = 1;

        public void AddAnimal(Animal animal) {
            if (_animals.Count == _maxZooCap)
            {
                Console.WriteLine("Достигнут предел вместимости зоопарка.");
                return;
            }
            if (CheckMaxCapZoo() == true)
            {
                _animals.Add(animal);
            }
            else
            {
                throw new Exception("11");
            }
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
        public void ZooInfo()
        {
            foreach (Animal animal in _animals)
            {
                animal.Info();
            }
        }
        public void animalFoundByType( Species animalType)
        {
            foreach (Animal animal in _animals)
            {
                if(animal.GetSpecies() == animalType)
                {
                    animal.Info();
                }
            }
            //return animal;
        }
        public void SetMaxCapZoo(int ZooCap)
        {
            _maxZooCap = ZooCap;
        }
        public bool CheckMaxCapZoo()
        {
            if(_maxZooCap < 0)
            {
                throw new Exception("Зоопарк не может быть меньше 0!");
                return false;
            }
            else if(_animals.Count > _maxZooCap)
            {
                //int aC = _animals.Count;
                //int result = aC - _maxZooCap;
                

                Console.WriteLine($"Нельзя больше вместить животных!");
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
