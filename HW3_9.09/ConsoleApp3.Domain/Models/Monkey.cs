namespace Zoo_Animals_project.Domain.Models
{
    public class Monkey : Animal {
        private bool _canClimb;

        public Monkey(string name, int age, Species species, bool canClimb) : base(name, age, species) {
            _canClimb = canClimb;
        }

        
        public override void MakeSound() {

            Console.WriteLine("Ржу");
        }
        public void Climb()
        {
        if (_canClimb == true) { 
            Console.WriteLine("Может взбираться"); 
        }
        else { 
            Console.WriteLine("Не может взбираться"); 
        }

        }

    }

}
