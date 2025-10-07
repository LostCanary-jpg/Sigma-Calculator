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
                Thread.Sleep(4000);
                Console.WriteLine("Press any key to exit...(dont be tuff)");
                Console.ReadKey();
                Environment.Exit(0);

            }
            else if (operation == 1)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII you playing with me");
                    Thread.Sleep(3000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("BROOIIIII THOUGHT YOU COULD SAKE ME OFF");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" BOII THOUGHT HE WAS SNEAKY!! TRY AGAIN");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double eredmeny = elso + masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("BOIIII TS SOO TUFFF!!!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }



            }

            else if (operation == 2)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII stop fooling with me gang");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("BROOIIIIIIIIIIIIIIII stop it, get some help");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine("      I need to get a life");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double eredmeny = elso - masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("BOI IS THIS TUFF?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }

            else if (operation == 3)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOII BOIII, im gonna find you");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("this is malware");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" BOI, i hate that im forcing myself to do this");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double eredmeny = elso * masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("TUFFFF IS THIS BOII??");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            else if (operation == 4)
            {
                Console.WriteLine("Give me the first number.");
                double elso = Convert.ToDouble(Console.ReadLine());
                if (elso == 67)
                {
                    Console.WriteLine(" BOIIIII. no boi. lock in.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Give me the second number.");
                double masodik = Convert.ToDouble(Console.ReadLine());
                if (masodik == 67)
                {
                    Console.WriteLine("get back to work. without change theres no change.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (elso == 6 && masodik == 7)
                {
                    Console.WriteLine(" STAY HARD");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double eredmeny = elso / masodik;
                if (eredmeny == 67)
                {
                    Console.WriteLine("its not a choice.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{eredmeny}");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press any key to exit...(dont be tuff)");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            Thread.Sleep(1000);
            Console.WriteLine("Press any key to exit...(dont be tuff)");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
