using Animals.Interfaces;

namespace Animals.Entities
{
    public abstract class Person : ITalkable
    {
        private string Name{get;set;}

        public virtual string GetName()
        {
            return Name;
        }

        public virtual string Talk()
        {
            return "Silence";
        }

    }


}