using System.Drawing;
using Animals.Interfaces;

namespace Animals.Entities
{
    public class ZooDriver
    {
        public void userMenu(List<ITalkable> zoo)
        {
            string NewThingName;
            int TeacherAge = 34;
            int NewMice = 0;
            bool DogIsFriendly = false;
            string choice = "";

            // display choices to user
            Console.Clear();
            Console.WriteLine("Please enter the number of the item you would like to create: \n"+
                "1.  Teacher\n"+
                "2.  Dog\n"+
                "3.  Cat",Color.Green);

            // read the input selection
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // add Teacher
                Console.WriteLine("Enter the teacher's name>>  ");
                NewThingName = Console.ReadLine();
                Console.WriteLine("Enter the teacher's age (between 20 & 70)>>  ");
                try
                {
                    TeacherAge = Int32.Parse(Console.ReadLine());
                        if(TeacherAge < 20 || TeacherAge > 75)
                        {
                            Console.WriteLine("Invalid entry.  Age defaulted to 34\n");
                            TeacherAge = 34;
                        }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception thrown:  "+ex);
                }

                zoo.Add(new Teacher(TeacherAge,NewThingName));
                
            }
            else if (choice == "2")
            {
                // add Dog
                Console.WriteLine("Enter the dog's name>>  ");
                NewThingName = Console.ReadLine();
                Console.WriteLine("Is the dog friendly (Y/N)?  ");
                try
                {
                    char newFriendly = Console.ReadLine()[0];
                    DogIsFriendly = (newFriendly == 'y' || newFriendly == 'Y')? true : false;
                    if(!DogIsFriendly)
                    {
                        Console.WriteLine("Invalid entry. Dog by default is not friendly\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception thrown:  "+ex);
                }

                zoo.Add(new Dog(DogIsFriendly,NewThingName));
            }
            else if (choice == "3")
            {
                // add Cat
                Console.WriteLine("Enter the cat's name>>  ");
                NewThingName = Console.ReadLine();
                Console.WriteLine("How many mice killed (between 0 and 25)?  ");
                try
                {
                    NewMice = Int32.Parse(Console.ReadLine());
                    if(NewMice < 0 || NewMice > 25)
                    {
                        Console.WriteLine("Invalid entry.  By default, the number of mice killed is 0\n");
                        NewMice = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception thrown:  "+ex);
                }

                zoo.Add(new Cat(NewMice,NewThingName));
            }
            else
            {
                Console.WriteLine(" No new items added to the zoo. ");
            }
        }
    }
}