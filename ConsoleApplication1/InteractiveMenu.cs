using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InteractiveMenu
    {

        // If the user selects to look at the expected SARSA algorithm options they
        // are calling this particular function.
        private static void expectedSARSAMenuOptions()
        {
            string input = "placeholder";
            while (input != "back")
            {
                //Because that console was hell of a lot of a mess.
                Console.Clear();
                //Options for Expected SARSA.
                Console.WriteLine("~~Expected SARSA Options!~~\n");
                Console.WriteLine("\"JUST RUN\" options, they will print to the console.\nFair warning, this will likely fill the terminal.");
                Console.WriteLine("1: es1m              --Run Expected SARSA for 1,000,000 episodes)");
                Console.WriteLine("2: es100k            -- Run Expected SARSA for 100,000 episodes");
                Console.WriteLine("3: esclear           -- Clear the current Q (THIS WILL LOSE LEARNING!)\n");

                //Options for 
                Console.WriteLine("~GRAPHICAL OPTIONS, choose these to view the grid in action!");
                Console.WriteLine("1: esgraphical       --Run the Expected SARSA algorithm in a grid!");
                Console.WriteLine("             *Only prints grid, doesn't move yet!");


                //General options like going back to the main menu
                Console.WriteLine("\n~~GENERAL OPTIONS:");
                Console.WriteLine("1: back              --Return to the main menu");

                //Get the user input
                Console.Write("Please enter your option here: ");
                input = Console.ReadLine();

                if (input == "es1m")
                {

                    Initializations.beginExpectedSARSA("es1m");
                    Console.Write("Success! Enter any key to continue");
                    Console.ReadLine();
                }

                else if (input == "es100k")
                {

                    Initializations.beginExpectedSARSA("es10k");
                    Console.Write("Success! Enter any key to continue");
                    Console.ReadLine();
                }

                else if (input == "esclear")
                {
                    Models.clearSARSAList();
                    Console.WriteLine("Expected SARSA learning cleared!");
                    Console.Write("Success! Enter any key to continue");
                    Console.ReadLine();

                }

                //Option from the user to view the graphical grid 
                else if (input == "esgraphical")
                {
                    GraphicalVisualizations.viewGrid();
                    Console.Write("\nSuccess! Enter any key to continue");
                    Console.ReadLine();
                }

                else if (input == "back")
                {
                    return;
                }

            }
            

        }



        /* This is the core method called by main, this is going to orchestrate a cascade
         * of options, there are no calculations done here. Just a bunch of very simple
         * string filters.
         */
        public static void beginInteractiveMenu()
        {
            //Need to initialize the string that will hold the user's console input.
            WriteAtClass writer = Initializations.writer;
            string input = "placeholder";
            while (input != "q" || input == "5")
            {
                //Clear the console to prevent it from getting too messy (and thus distracting).
                Console.Clear();

                bool printGrid = false;
                string printStepSize = "";

                

                //Output to console giving the user options. 
                Console.WriteLine();
                Console.WriteLine("This is the interactive menu, please enter a key to choose your option!");
                Console.WriteLine("(Please put the input in EXACTLY as shown to the far left!)\n");
                Console.WriteLine("Example: enter exactly \"expectedsarsa\" to choose that option! ");
                Console.WriteLine("~~ALGORITHMS: ");
                Console.WriteLine("1: expectedsarsa --See the various options for the Expected SARSA algorithm\n\n");

                Console.WriteLine("~~CONFIG:");
                Console.WriteLine("2: config        --Configure the values presented to the algorithms here");
                Console.WriteLine("3: printinc      -- Enter a whole number value of how many steps to take between prints");
                Console.WriteLine("                      (Default is ~ 1,000 steps with a few starting positions)");
                Console.WriteLine("4: printall      --Print all learned policies");
                Console.WriteLine("5: q             --Quit");

                //Obtain user input with a small prompt
                Console.Write("\nPlease put your option here: ");
                input = Console.ReadLine();



                //Now we have the various options, very simple if statement breakdown.
 

                if (input == "printinc" || input == "3")
                {
                    Console.Write("Please enter numeric value (And please not 0 or lower!): ");
                    string printIncString = Console.ReadLine();
                    int printIncInt = 0;

                    bool intParseSuccess = int.TryParse(printIncString, out printIncInt);
                    if (intParseSuccess == false)
                    {
                        Console.WriteLine("Sorry something went wrong when parsing that int. Try a number like 1000?");
                        Console.Write("\nEnter any key to continue");
                        Console.ReadLine();
                    }
                    if (intParseSuccess == true)
                    {
                        if (printIncInt <= 0)
                        {
                            //Error: User put in a value below zero, inform them.
                            Console.WriteLine("Whoops! Number entered was below 1, please try a new positive integer!");
                            Console.Write("\nEnter any key to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            //Confirm to the user that the number was modified.
                            Console.Write("Number changed! ");
                            Console.WriteLine(printIncInt);
                            Console.Write("\nEnter any key to continue");
                            Console.ReadLine();
                        }
                    }

                }

                else if (input == "expectedsarsa" || input == "1")
                { 
                    // Just invoke the method that deals with that end of the menu.
                    expectedSARSAMenuOptions();
                }

                else if (input == "config" || input == "2")
                {
                    Console.Write("Sorry, option not here yet!\nEnter any key to continue");
                    Console.ReadLine();
                }

                else if (input == "printall" || input == "4")
                {
                    Console.Write("Sorry, option not here yet!\nEnter any key to continue");
                    Console.ReadLine();
                }

            }

        }


        
    }
}
