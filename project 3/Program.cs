using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = "";
            int ownerAction; 
            
            Console.WriteLine("Welcome to the VirtuaDog App");
            Console.ReadLine();

            Dog dogOwner = new Dog();

            do
            {
                
                dogOwner.Tick();
                Console.WriteLine();

                Console.WriteLine("<LINCOLNS CURRENT STATUS>");
                dogOwner.Dogstatus();
                Console.WriteLine();

                Console.WriteLine("To Feed Lincoln...........: Type 1");
                Console.WriteLine("To let Lincoln OutSide....: Type 2");
                Console.WriteLine("To give Licoln a Treat....: Type 3");
                Console.WriteLine("To exit.................. : Type exit ");

                ownerAction = int.Parse(Console.ReadLine());

                switch (ownerAction)
                {

                    case 1:
                        dogOwner.FeedDog();
                        break;

                    case 2:
                        dogOwner.PottyStatus();
                        break;

                    case 3:
                        dogOwner.WantaTreat();
                        break;

                    default:
                        break;

                }

                action = " ";  
            } while (action != "exit");
            {
             Console.WriteLine("Thanks for using the VirtualDog app"); 
            }
           


        }
    }
}    

