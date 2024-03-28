using Animals.Interfaces;

namespace Animals.Entities{

    public abstract class Pet : ITalkable
    {
        private string Name{get; set;}

        public virtual string Talk()
        {
            return "Silence";
        }

        public virtual string GetName()
        {
            return Name;
        }
    }

}