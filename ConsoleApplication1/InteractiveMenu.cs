using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InteractiveMenu
    {

        public static void beginInteractiveMenu()
        {
            //Need to initialize the string that will hold the user's console input.
            WriteAtClass writer = Initializations.writer;
            string input = "placeholder";
            while (input != "q")
            {
                bool printGrid = false;
                string printStepSize = "";

                //Output to console giving the user options. 
                Console.WriteLine();
                Console.WriteLine("This is the interactive menu, please enter a key to choose your option!");
                Console.WriteLine("(Please put the input in EXACTLY as shown to the far left!)");
                Console.WriteLine("es1m   --Run Expected SARSA for 1,000,000 episodes)");
                Console.WriteLine("es100k -- Run Expected SARSA for 100,000 episodes");
                Console.WriteLine("esclear -- Clear the current Q (THIS WILL LOSE LEARNING!)");
                Console.WriteLine("printinc -- Enter a whole number value of how many steps to take between prints");
                Console.WriteLine("             (Default is ~ 1,000 steps with a few starting positions)");
                Console.WriteLine("Print all learned policies");
                Console.WriteLine("q   --Quit");

                input = Console.ReadLine();



                //Now we have the various options, very simple if statement breakdown.
                if (input == "es1m")
                {
                    
                    Initializations.beginExpectedSARSA("es1m");
                }

                else if (input == "es100k")
                {

                    Initializations.beginExpectedSARSA("es10k");
                }

                else if (input == "esclear")
                {
                    Models.clearSARSAList();
                    Console.WriteLine("Expected SARSA learning cleared!");
 
                }

                else if (input == "printinc")
                {
                    Console.Write("Please enter numeric value (And please not 0 or lower!): ");
                    string printIncString = Console.ReadLine();
                    int printIncInt = 0;

                    bool intParseSuccess = int.TryParse(printIncString, out printIncInt);
                    if (intParseSuccess == false)
                    {
                        Console.WriteLine("Sorry something went wrong when parsing that int. Try a number like 1000?");
                    }
                    if (intParseSuccess == true)
                    {
                        if (printIncInt <= 0)
                        {
                            Console.WriteLine("Whoops! Number entered was below 1, please try a new positive integer!");
                        }
                        else
                        {
                            Console.Write("Number changed! ");
                            Console.WriteLine(printIncInt);
                        }
                    }

                }

                //Option from the user to view the graphical grid 
                else if (input == "esgraphical")
                {
                    GraphicalVisualizations.viewGrid();
                }
            }

        }


        
    }
}
