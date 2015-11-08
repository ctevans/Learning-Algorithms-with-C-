using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Please note: I found this extremely useful bit of code that I am using here from the following source:
 * https://msdn.microsoft.com/en-us/library/system.console.setcursorposition(v=vs.110).aspx
 *
 * I added a few things like a constructor, but the primary core is totally credited towards microsoft. 
 */

namespace ConsoleApplication1
{
    class WriteAtClass
    {
        protected static int origRow;
        protected static int origCol;

        public WriteAtClass(int givenStartRow, int givenStartCol)
        {
            origRow = givenStartRow;
            origCol = givenStartCol;

        }

        public void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

    }
}
