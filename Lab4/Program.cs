using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int UserNumber;
            string UserChoice;

            //Allow to play again
            UserChoice = "y";
            while (UserChoice.ToLower() == "y")
            {
                //body of loop

            //input validation
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome- Enter an integer");
                    UserNumber = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception f)
                {
                    Console.WriteLine(f.Message);
                }
            }

            //process
            Console.Write("Number".PadRight(10));
            Console.Write("Squared".PadRight(10));
            Console.WriteLine("Cubed");
            Console.Write("======".PadRight(10));
            Console.Write("=======".PadRight(10));
            Console.WriteLine("=====");
            for (int i = 1; i <= UserNumber; i++)
            {
                //for(int j = 1; j<=1; j++) - Unessesary
                {
                  //output
                    Console.Write(i.ToString().PadRight(10));
                    Console.Write((i * i).ToString().PadRight(10));
                    Console.WriteLine((i * i * i).ToString());
                }
                             
            }
            Console.WriteLine("Would you like to run again? \"(y/n)\"");
            UserChoice = Console.ReadLine();
        }

        //Continue upon user request loop


        //Console.ReadKey();
        }
    }
}
