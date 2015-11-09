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
            string input = "placeholder";
            while (input != "q")
            {

                //Output to console giving the user options. 
                Console.WriteLine();
                Console.WriteLine("This is the interactive menu, please enter a key to choose your option!");
                Console.WriteLine("(Please put the input in EXACTLY as shown to the far left!)");
                Console.WriteLine("es1m   --Run Expected SARSA for 1,000,000 episodes)");
                Console.WriteLine("es100k -- Run Expected SARSA for 100,000 episodes");
                Console.WriteLine("esclear -- Clear the current Q (THIS WILL LOSE LEARNING!)");
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
            }

        }


        
    }
}
