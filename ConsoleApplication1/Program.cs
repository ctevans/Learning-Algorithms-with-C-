using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This is the core entry point for this program. 
 * My goal here was to just have a very simple and clean main that is 
 * going to make calls to other methods and classes to handle all of the rest of the work.
 *
 * Functions currently here:
 *
 * 1: A call to the beginInteractiveMenu() method from the InteractiveMenu class
 *     which will begin the menu that the user may interact with to choose various
 *     options.
 *
 * 2: A call to the entireProgramComplete() method from the CompletionAnalysis
 * class. This is going to handle any closing remarks, etc that I need. At 
 * present it is pretty barren yet I have hopes to expand it to show some
 * interesting stats later!
 */

namespace ConsoleApplication1
{
    class Program 
    {
        static void Main(string[] args)
        {

            

            //Initial printing occurs right here.
            InteractiveMenu.beginInteractiveMenu();

            //This is the function called when we print out the results of what was ran.
            //Program finished after this point :)
            CompletionAnalysis.entireProgramComplete();

        }
    }
}
