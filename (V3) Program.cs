using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.Design;
using System.Transactions;

namespace Sigma_calculator
{
    internal class Program
    {
        // Global dictionary to storee  chosen language, blah blan, just to be safe and when code gets bigger
                    static Dictionary<string, string> currentLang = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            

            while (true)
            {
                try
                {
                    string version = "[V3/2025-10-07]";
                    SetLanguage();
                    Console.WriteLine();
                    Console.WriteLine(currentLang["opening"]);
                    Console.Write(currentLang["helpLine"]);
                    Console.WriteLine();

                    Console.WriteLine(currentLang["operationAsk"]);
                    double operation = Convert.ToDouble(Console.ReadLine());

                    if (operation == 67)
                    {
                        ShowHelp();
                        Thread.Sleep(2000);
                        calcRestart();

                    }
                    static void ShowHelp()
                    {
                        Console.WriteLine();
                        Console.WriteLine(currentLang["addition"]);
                        Console.WriteLine(currentLang["subtraction"]);
                        Console.WriteLine(currentLang["multiplication"]);
                        Console.WriteLine(currentLang["division"]);
                        Console.WriteLine();
                        Console.WriteLine(currentLang["exit-code"]);
                        Console.WriteLine();
                    }

                    if (operation == 69)
                    {
                        Console.Write(currentLang["version/code"]); Console.WriteLine($"{version}.");
                        Console.WriteLine(currentLang["right-reserved"]);
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.WriteLine(currentLang["continue"]);
                        Console.ReadKey();
                        break;
                    }

                    if (operation == 99)
                    {
                        exit99();
                    }


                    if (operation == 1)
                    {
                        Console.WriteLine(currentLang["first/numero"]);
                        double elso = Convert.ToDouble(Console.ReadLine());
                        if (elso == 67)
                        {
                            Console.WriteLine(currentLang["br67-1.01"]);
                            Thread.Sleep(2000);
                            pressRestart();
                        }
                        Console.WriteLine(currentLang["second/numero"]);
                        double masodik = Convert.ToDouble(Console.ReadLine());
                        if (masodik == 67)
                        {
                            Console.WriteLine(currentLang["br67-1.02"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else if (elso == 6 && masodik == 7)
                        {
                            Console.WriteLine(currentLang["br67-1.03"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        double eredmeny = elso + masodik;
                        if (eredmeny == 67)
                        {
                            Console.WriteLine(currentLang["br67-1.04"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{eredmeny}");
                            Thread.Sleep(1000);
                            calcRestart();
                        }



                    }

                    else if (operation == 2)
                    {
                        Console.WriteLine(currentLang["first/numero"]);
                        double elso = Convert.ToDouble(Console.ReadLine());
                        if (elso == 67)
                        {
                            Console.WriteLine(currentLang["br67-2.01"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        Console.WriteLine(currentLang["second/numero"]);
                        double masodik = Convert.ToDouble(Console.ReadLine());
                        if (masodik == 67)
                        {
                            Console.WriteLine(currentLang["br67-2.02"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else if (elso == 6 && masodik == 7)
                        {
                            Console.WriteLine(currentLang["br67-2.03"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        double eredmeny = elso - masodik;
                        if (eredmeny == 67)
                        {
                            Console.WriteLine(currentLang["br67-2.04"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{eredmeny}");
                            Thread.Sleep(1000);
                            calcRestart();

                        }
                    }
                    else if (operation == 3)
                    {

                        Console.WriteLine(currentLang["first/numero"]);
                        double elso = Convert.ToDouble(Console.ReadLine());
                        if (elso == 67)
                        {
                            Console.WriteLine(currentLang["br67-3.01"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        Console.WriteLine(currentLang["second/numero"]);
                        double masodik = Convert.ToDouble(Console.ReadLine());
                        if (masodik == 67)
                        {
                            Console.WriteLine(currentLang["br67-3.02"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else if (elso == 6 && masodik == 7)
                        {
                            Console.WriteLine(currentLang["br67-3.03"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        double eredmeny = elso * masodik;
                        if (eredmeny == 67)
                        {
                            Console.WriteLine(currentLang["br67-3.04"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{eredmeny}");
                            Thread.Sleep(1000);
                            calcRestart();
                        }
                    }

                    else if (operation == 4)
                    {
                        Console.WriteLine(currentLang["first/numero"]);
                        double elso = Convert.ToDouble(Console.ReadLine());
                        if (elso == 67)
                        {
                            Console.WriteLine(currentLang["br67-4.01"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        Console.WriteLine(currentLang["second/numero"]);
                        double masodik = Convert.ToDouble(Console.ReadLine());
                        if (masodik == 67)
                        {
                            Console.WriteLine(currentLang["br67-4.02"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else if (elso == 6 && masodik == 7)
                        {
                            Console.WriteLine(currentLang["br67-4.03"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        double eredmeny = elso / masodik;
                        if (eredmeny == 67)
                        {
                            Console.WriteLine(currentLang["br67-4.04"]);
                            Thread.Sleep(1000);
                            pressRestart();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{eredmeny}");
                            Thread.Sleep(1000);
                            calcRestart();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid");
                        Thread.Sleep(1000);
                        calcRestart();

                    }

                    /*
                     * updated to Net.8 instead of net 4.7 framework
                       continues  loop instead of restarting after every calculation. with do you want to exit.
                       some tweaks to the code (better on the eyes)
                       mini failsafe (not properly tested)
                       version code  command (hidden code, only for developers hihihiha. its 69 in the first opportunity)
                        proper failsafe implemented.
                     */
                    
                }
                catch
                {
                    Console.WriteLine(currentLang["catch/1"]);
                    Console.WriteLine(currentLang["catch/2"]);
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    calcRestart();
                    break;

                }

                static void calcRestart()
                {
                    Console.WriteLine(currentLang["calcResLine"]);
                    Console.WriteLine(currentLang["calcRestart"]);
                    string? choice = Console.ReadLine()?.ToLower();
                    if (choice == "y")
                    {
                        Console.Clear();
                        Main(new string[0]);

                    }
                    else
                    {
                        Console.WriteLine(currentLang["calcBye"]);
                        Thread.Sleep(1000);
                        Environment.Exit(0);

                    }
                }  
                
                static void pressRestart ()
                {
                    Console.WriteLine(currentLang["pressRestart"]);
                    Console.ReadKey();
                    Console.Clear();
                    Main(new string[0]);
                }

                static void exit99 ()
                {
                    Console.WriteLine(currentLang["exit/staticV-1"]);
                    Console.WriteLine(currentLang["exit/staticV-2"]);
                    Thread.Sleep(1000);
                    Environment.Exit(0); 
                }

                    static void SetLanguage()
                {
                    Console.WriteLine("Choose language/Válasz nyelvet!");
                    Console.WriteLine("  6 - English/Angol");
                    Console.WriteLine("  7 - Magyar/Hungarian");
                    string? choice = Console.ReadLine();

                    var english = new Dictionary<string, string>()
                    {
                        {"opening", "This is a dumb but Sigma-Calculator!" },
                        {"helpLine", "  [If you don't know the numbering of the operations type 67 at the first opportunity for help!]" },
                        {"operationAsk", "Input the operation you want to do." },
                        {"addition", " Addition = 1" },
                        {"subtraction"," Subtraction = 2" },
                        {"multiplication", " Multiplication = 3" },
                        {"division", " Division = 4" },
                        {"exit-code", " [Exit = 99]" },
                        {"version/code", "The current version is " },
                        {"right-reserved", "All rights reserved. Unauthorized reproduction or distribution of this material is prohibited." },
                        {"continue", "Press any key to continue..." },
                        {"first/numero", "Give me the first number." },
                        {"second/numero", "Give me the second number." },

                        {"br67-1.01", " BOIIIII you playing with me" },
                        {"br67-1.02", " BROOIIIII THOUGHT YOU COULD SAKE ME OFF" },
                        {"br67-1.03", " BOII THOUGHT HE WAS SNEAKY!! TRY AGAIN" },
                        {"br67-1.04", " BOIIII TS SOO TUFFF!!!"},

                        {"br67-2.01", " BOIIIII stop fooling with me gang" },
                        {"br67-2.02", " BROOIIIIIIIIIIIIIIII stop it, get some help" },
                        {"br67-2.03", " I need to get a life" },
                        {"br67-2.04", " BOI IS THIS TUFF?"},

                        {"br67-3.01", " BOII BOIII, im gonna find you." },
                        {"br67-3.02", " this is malware" },
                        {"br67-3.03", " BOI, i hate that im forcing myself to do this" },
                        {"br67-3.04", " TUFFFF IS THIS BOII??" },

                        {"br67-4.01", " BOIIIII-. there's no boi. lock in." },
                        {"br67-4.02", " Get back to work. Without change theres no change." },
                        {"br67-4.03", " STAY HARD" },
                        {"br67-4.04", " It's not a choice." },

                        {"catch/1", "     If it wasn't for me, you would've crashed." },
                        {"catch/2", "                Your welcome gang" },

                        {"calcResLine", "-------------------------------" },
                        {"calcRestart", " Do you want to restart?  (y/n)" },
                        {"calcBye", "Goodbye gng" },

                        {"pressRestart", "Press any key to restart...(Don't be tuff)" },

                        {"exit/staticV-1", "__________________" },
                        {"exit/staticV-2", "See you later twin." },

                    };

                    var hungarian = new Dictionary<string, string>()
                    {
                        {"opening", "Ez egy buta de Szigma-Számológép!" },
                        {"helpLine", "[Ha nem tudod a számozását a műveleteknek akkor írd be hogy 67 az elso lehetosegeknél]" },
                        {"operationAsk", "Add meg melyik műveletet szeretnéd végezni"},
                        {"addition", " Összeadás = 1" },
                        {"subtraction", " Kivonás = 2" },
                        {"multiplication", " Szorzás = 3" },
                        {"division", " Osztás = 4"},
                        {"exit-code", " [Bezárás = 99]" },
                        {"version/code", "A jelenlegi verzió " },
                        {"right-reserved", "Minden jog fenntartva. A jelen anyag engedély nélküli sokszorosítása vagy terjesztése tilos." },
                        {"continue", "Nyomjon meg bármelyik billentyűt a folytatáshoz..." },
                        {"first/numero", "Add meg az első számot." },
                        {"second/numero", "Add meg a második számot." },

                        {"br67-1.01", " BOIIIII azt hiszed játszol velem" },
                        {"br67-1.02", " BROOIIIII AZT HITTED LERÁZOL" },
                        {"br67-1.03", "  BOII AZT HITTE SNEAKY!! PROBALD UJRA" },
                        {"br67-1.04", " BOIIII TS SOO TUFFF!!!"},

                        {"br67-2.01", " BOIIIII ne bolondozz velem gang" },
                        {"br67-2.02", " BROOIIIIIIIIIIIIIIII hagyd abba, szerezz segítséget" },
                        {"br67-2.03", " Elkéne kezdenem normálisnak lenni" },
                        {"br67-2.04", " BOI EZ TUFF?"},

                        {"br67-3.01", " BOII BOIII, megfoglak találni." },
                        {"br67-3.02", " ez egy vírus"},
                        {"br67-3.03", " BOI, utálom hogy rákényszerítem magam erre"},
                        {"br67-3.04", " TUFF EZA THIS BOII??" },

                        {"br67-4.01", " BOIIIII-. nincs boi. Lock in." },
                        {"br67-4.02", " Menj vissza dolgozni. Változás nélkül nincsen változás." },
                        {"br67-4.03", " KITARTÁST!" },
                        {"br67-4.04", " Nincs valasztas." },

                        {"catch/1", "     Ha nem lettem volna, be crash-eltél volna lil bro." },
                        {"catch/2", "                       Nincs mit gang" },

                        {"calcResLine", "-----------------------------"},
                        {"calcRestart", " Ujra akarod inditani?  (y/n)" },
                        {"calcBye", "Viszlát gng" },

                        {"pressRestart", "Nyomj meg egy gombot az újraindításhoz... (Ne légy tuff)" },

                        {"exit/staticV-1", "-----------------------"},
                        {"exit/staticV-2", "Később találkozunk twin."},


                    };

                    if (choice == "7")
                    { currentLang = hungarian; }
                    else if (choice == "6")
                    { currentLang = english; }
                    else if (choice == "99")
                    {
                        exit99();
                    }
                    else if (choice == "67")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Addition       = 1      [Összeadás]");
                        Console.WriteLine(" Subtraction    = 2      [Kivonás]");
                        Console.WriteLine(" Multiplication = 3      [Szorzás]");
                        Console.WriteLine(" Division       = 4      [Osztás]");
                        Console.WriteLine();
                        Console.WriteLine(" [Exit = 99]             [Bezárás]");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                            calcRestart();

                    }
                    else
                    {
                        Console.WriteLine("You tweaking gng, that aint a language.");
                        calcRestart();

                    }
                    
                    
                }

                // TO DO:  work on console.clear. and fix restart. optimise code with static voids. ---------DONE
                /* fix static voids ---------DONE
                 * complete static void hungarian.
                 * test failsafe for crashes in the first opportunity in languages with restart etc -------DONE
                 * 
                 * change it up and add an exit to the first opportunitly (not the language part but the give me operation part so people can exit easily ---DONE, also to the language aswell.
                 */
            }
        }
    }
}


