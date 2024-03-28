using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Animals.Entities;
using Animals.Interfaces;

namespace Animals{

    public class Program
    {
        public static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44,"Stacy Read"));


            foreach(ITalkable talkable in zoo){
                Console.WriteLine(talkable);
            }
            
            
        }
    }
}