using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Initializations
    {
        //Core algorithmic controller variables. 
        //gamma = the amount of 
        public static double gamma = 1;
        public static double alpha = 0.001;
        public static double epsilonpi = 0.01;
        public static double epsilonmu = 0.01;

        //Random number generator for drawing randoms. Used a lot in algorithms implemented.
        public static Random random = new Random();

    

        public static void beginExpectedSARSA()
        {
            int trials = 100000;

            for (int i = 0; i < trials; i++)
            {
                ExpectedSarsa.expectedSARSA();
            }


        }

    }
}
