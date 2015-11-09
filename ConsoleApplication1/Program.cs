using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program 
    {
        static void Main(string[] args)
        {

            //Instantiate a new WriteAtClass object and assign it start params
            WriteAtClass writer = new WriteAtClass(4, -3);
            //Originally 4, -3
            //Initial printing occurs right here.
            PrintFormat.initialPrint();
            PrintFormat.firstAgentPrint(writer);
            PrintFormat.statePrint(writer);
            PrintFormat.initialPolicyPicks(writer);

            InteractiveMenu.beginInteractiveMenu();
            




            //This is the function called when we print out the results of what was ran.
            //Program finished after this point :)
            CompletionAnalysis.entireProgramComplete(writer);

        }
    }
}
