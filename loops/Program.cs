using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your target?");
            int Target = int.Parse(Console.ReadLine());

            Console.WriteLine("______________________________________________");

            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
            Console.ReadLine();*/


            /*int CoffeeCups = 0;

            Start:
            Console.WriteLine("Enter your choice : 1 - Small, 2 - Medium, 3 - Large ");
            int YourChoice = int.Parse(Console.ReadLine());
            

            do
            {
                switch (YourChoice)
                {
                    case 1:
                        CoffeeCups += 1;
                        break;
                    case 2:
                        CoffeeCups += 2;
                        break;
                    case 3:
                        CoffeeCups += 3;
                        break;
                        
                    

                }

                Console.WriteLine("Do you want another coffee : Yes or No?");
                string YourDecision =  Console.ReadLine();

                Decision:
                switch (YourDecision.ToUpper())
                {
                    case "YES":
                        goto Start;
                    case "NO":
                        goto Final;
                    default:
                        Console.WriteLine("Invalid decision");
                        break;

                }



            } while (YourChoice == 1 || YourChoice == 2 || YourChoice == 3 );

            Console.WriteLine("Invalid choice");
            goto Start;
            

        Final:
            Console.WriteLine("Thank you , Come again");
            Console.WriteLine("Bil amount {0}", CoffeeCups);
            Console.ReadLine();*/


            int[] Numbers = new int[3];
            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;

            /*for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
                
            }*/

            foreach (int x in Numbers)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();



        }
    }
}
