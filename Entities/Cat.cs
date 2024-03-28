namespace Animals.Entities
{
    public class Cat : Pet
    {
        private int MousesKilled{get; set;}
        private string Name{get; set;}

        public Cat(int MousesKilled, string Name)
        {
            this.MousesKilled = MousesKilled;
            this.Name = Name;
        }

        public void AddMouse(){MousesKilled++;}

        public override string Talk()
        {
            return "Meow!!";
        }

        public new string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }
    }
}