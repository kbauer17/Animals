namespace Animals.Entities
{
    public class Teacher : Person 
    {
        private int Age{get;set;}
        private string Name{get; set;}

        public Teacher(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public override string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public new string GetName()
        {
            return Name;
        }
    }


}