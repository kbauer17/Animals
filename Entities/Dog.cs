using System.ComponentModel;

namespace Animals.Entities
{
    public class Dog : Pet
    {
        private bool Friendly{get; set;}
        private string Name{get; set;}

        public Dog(bool Friendly, string Name)
        {
            this.Friendly = Friendly;
            this.Name = Name;
        }

        public bool IsFriendly(){
            return Friendly;
        }
        public override string Talk()
        {
            return "Bark!!";
        }

        public new string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}