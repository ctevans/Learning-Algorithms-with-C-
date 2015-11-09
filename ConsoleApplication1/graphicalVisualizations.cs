using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GraphicalVisualizations
    {
        public static void viewGrid()
        {
            WriteAtClass writer = Initializations.writer;
            Console.Clear();
            PrintFormat.initialPrint();
            PrintFormat.firstAgentPrint(writer);
            PrintFormat.statePrint(writer);
            PrintFormat.initialPolicyPicks(writer);
        }

    }
}
