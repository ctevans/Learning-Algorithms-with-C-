using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**This is really just a class purely dedicated around printing stuff for me. I will put all functions
 * related to printing related material around here. 
 * 
 * Functions you can come to expect:
 * 1: initialPrint:
 *      This function takes in no parameters and just gives a basic initial printing of the grid that the agent
 *      will act upon. Upon completion will return a numerical value of 0 to represent success (good practice?)
 * 2: agentPrint:
 *      This function is going to basically be the "agent" in this environment. It is crude but it allows me to 
 *      try out these various learning methods for myself. I personally like emperical evidence.
 **/

namespace ConsoleApplication1
{
    class PrintFormat
    {
        static public  int initialPrint()
        {
            //A little statement that the user of the application to provide context
            Console.WriteLine("Basic application where I am trying to mimic the learning algorithms presented in my class." +
                "\nActions the agent can take: DN = down, UP = up, RT = Right, LT = left or alternatively \"EQ\" if all equal"+
                "\nAgent will be represented by a *AGENT*");

            //Here is the initial loop that prints out the grid that the agent will be acting upon
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 10) == 0)
                {
                    for(int i2 = 0; i2 <3; i2++)
                    {
                        Console.Write("|");
                        Console.WriteLine("\n|        |        |        |        |        |        |        |        |        | ");
                        
                    }


                    if (i == 90)
                    {
                        break;
                    }

                }
                Console.Write("|");
                Console.Write("--------");

            }
            return 0; //Meaning that this was successful.
        }

        //This code has a particular agent involved with itself. This is going to be how the agent is printed
        static public int firstAgentPrint(WriteAtClass writer)
        {
            writer.WriteAt("*AGENT*",4,2);
            return 0;

        }

        static public int statePrint(WriteAtClass writer)
        {
            int counter = 0;
            int columnNumber = 4;
            int rowNumber = 0;
            int stateCount = 100; //Perhaps in the future I'll let the user edit this. 

            for (int i = 0; i < stateCount; i++)
            {
                counter++;
                writer.WriteAt("State " + counter.ToString(), columnNumber, rowNumber);
                columnNumber = columnNumber + 9;

                if(columnNumber == 94)
                {
                    columnNumber = 4;
                    rowNumber = rowNumber + 6;
                }

            }
            return 0;
        }



        static public int initialPolicyPicks(WriteAtClass writer)
        {
            int counter = 0;
            int columnNumber = 5;
            int rowNumber = 4;
            int stateCount = 100; //Perhaps in the future I'll let the user edit this. 

            for (int i = 0; i < stateCount; i++)
            {
                counter++;
                writer.WriteAt(" EQ ", columnNumber, rowNumber);
                columnNumber = columnNumber + 9;

                if (columnNumber == 95)
                {
                    columnNumber = 5;
                    rowNumber = rowNumber + 6;

                }
            }
            //Upon success return 0
            return 0; 
        }

        static public int moveAgent(WriteAtClass writer, int currentCol, int currentRow, string direction)
        {
            //Delete wherever the agent was.
            writer.WriteAt("       ", currentCol, currentRow);
            
            //Direction taken to move the agent will be taken into account here.
            if (direction == "right")
            {
                currentCol = currentCol + 9;
            }

            if (direction == "left")
            {
                currentCol = currentCol - 9;
            }

            if (direction == "down")
            {
                currentRow = currentRow + 6;   
            }

            if (direction == "up")
            {
                currentRow = currentRow - 6;
            }

            //Whatever the change is, now write it.
            writer.WriteAt("*AGENT*", currentCol, currentRow);

            //Return with success.
            return 0;

        }








    }
}
