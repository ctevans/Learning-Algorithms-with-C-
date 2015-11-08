using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Policies
    {
        //All chances are equally probable with this policy! 
        //Nothing greedy about this at all. Nothing fancy. Pure randomness.
        public static int equiprobableRandomPolicy(Random random)
        {

            //Policies here are represented numerically. 
            // Translation:
            // 0 = UP
            // 1 = RIGHT
            // 2 = DOWN
            // 3 = LEFT
            
            int equiprobableRandomInt = random.Next(0, 100);

            if (equiprobableRandomInt < 25)
            {
                return 0; //return the first action type (up)
            }
            if (equiprobableRandomInt < 50)
            {
                return 1; //return the second action type (right)
            }
            if (equiprobableRandomInt < 75)
            {
                return 2; //return third action type (down)
            }
            else
            {
                return 3; //return fourth action type (left)
            }

        }


    }
}
