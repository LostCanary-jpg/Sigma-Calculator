using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sigma_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a dumb but sigma calculator");
            Console.Write(" [if you don't know the numbering of the operations type 67 at the first opportunity for help!]");

            Console.WriteLine();
            Console.WriteLine("Give me the operation you want to do.");
            double operation = Convert.ToDouble(Console.ReadLine());

            if (operation == 67)
            {
                Console.WriteLine();
                Console.WriteLine(" Addition = 1");
                Console.WriteLine(" Subtraction = 2");
                Console.WriteLine(" Multiplication = 3");
                Console.WriteLine(" Division = 4");
                Console.WriteLine();
                return;
            }
            else if (operation == 1)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII you playing with me");
                    return;
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("BROOIIIII THOUGHT YOU COULD SAKE ME OFF");
                    return;
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" BOII THOUGHT HE WAS SNEAKY!! TRY AGAIN");
                    return;
                }
                double eredmeny = elso + masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("BOIIII TS SOO TUFFF!!!");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    return;
                }



            }

            else if (operation == 2)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII stop fooling with me gang");
                    return;
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("BROOIIIIIIIIIIIIIIII stop it, get some help");
                    return;
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine("      I need to get a life");
                    return;
                }
                double eredmeny = elso - masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("BOI IS THIS TUFF?");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    return;
                }

            }

            else if (operation == 3)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOII BOIII, im gonna find you");
                    return;
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("this is malware");
                    return;
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" BOI, i hate that im forcing myself to do this");
                    return;
                }
                double eredmeny = elso * masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("TUFFFF IS THIS BOII??");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    return;
                }
            }

            else if (operation == 4)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII. no boi. lock in.");
                    return;
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("get back to work. without change theres no change.");
                    return;
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" STAY HARD");
                    return;
                }
                double eredmeny = elso / masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("its not a choice.");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    return;
                }
            }

            return;
        }
    }
}
