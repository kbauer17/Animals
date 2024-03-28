using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Animals.Entities;
using Animals.Interfaces;

namespace Animals{

    public class Program
    {
        public static void Main(string[] args)
        {
            // designate the file to read/write to
            string zooFilePath = Directory.GetCurrentDirectory() + "//animals.txt";
            
            
            List<ITalkable> zoo = new List<ITalkable>();
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44,"Stacy Read"));


            foreach(ITalkable talkable in zoo){
                Console.WriteLine(talkable.GetName() + " says " + talkable.Talk());
                // write it to the file
                try
                {
                    StreamWriter sw = new StreamWriter(zooFilePath, true);
                    sw.WriteLine("{0} | {1}",talkable.GetName(),talkable.Talk());
                    sw.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            
            
        }
    }
}