using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Initializations
    {


        //Instantiate a new WriteAtClass object and assign it start params
        //Originally 4, -3
        public static WriteAtClass writer = new WriteAtClass(4, -3);


        //Core algorithmic controller variables. 
        //gamma = the amount of 
        public static double gamma = 1;
        public static double alpha = 0.001;
        public static double epsilonpi = 0.01;
        public static double epsilonmu = 0.01;

        //Random number generator for drawing randoms. Used a lot in algorithms implemented.
        public static Random random = new Random();

    

        public static void beginExpectedSARSA(string flag)
        {
            int trials = 0; //default, will never be used. Just to make Visualstudio happy.
            if (flag == "es1m") { trials = 1000000; }
            else if (flag == "es10k") { trials = 100000; };


            //Fancy block where I use the number of trials chosen by the user in the menu to iterate.
            //I send a print-flag and an integer after it to indicate if the algorithm is to print
            //it's current round to the screen, and if it is then I hand it the trial number.
            for (int i = 0; i < trials; i++)
            {
                ExpectedSarsa.expectedSARSA(false, 0);

                if (i % 1000 == 0 || i == 1 || i == 5 || i == 10 || i == 100 || i == 200 || i == 500 && i != 0)
                {
                    ExpectedSarsa.expectedSARSA(true, i);
                }


            }


        }

    }
}
