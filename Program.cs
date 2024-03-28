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
            // zoo.Add(new Dog(true, "Bean"));
            // zoo.Add(new Cat(9, "Charlie"));
            // zoo.Add(new Teacher(44,"Stacy Read"));

            ZooDriver userZoo = new ZooDriver();
            userZoo.userMenu(zoo);

            Console.WriteLine("\n  Output directly from the zoo list:  \n");
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
            
            // read from the file
            try
            {
                StreamReader sr = new StreamReader(zooFilePath);
                Console.WriteLine("\n  ...and now reading from the file:  \n");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Read Error:  " + zooFilePath + ex.Message);
            }

        }
    }
}