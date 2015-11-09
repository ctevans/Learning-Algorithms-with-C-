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
        private static double gamma = 1;
        private static double alpha = 0.001;
        private static double epsilonpi = 0.01;
        private static double epsilonmu = 0.01;

        //Random number generator for drawing randoms. Used a lot in algorithms implemented.
        public static Random random = new Random();

        //I need to compare the maximum value for expected SARSA so I ended up throwing together the standard c#
        //Math.Max library function. But instead I did a bunch of nesting and tailored it to my needs. 
        //There are 4 total actions for any given state, so I ended up actually making it so that there are 4 
        //maximum's
        private static double max(double a, double b, double c, double d)
        {
            double maxOfFour = Math.Max(a, Math.Max(b, Math.Max(c, d)));

            return maxOfFour;
        }

        //I divided the summation symbol of the traditional Expected SARSA algorithm into parts. This is the second part.
        //If you look at the equation there is a summation symbol, I took it out of the equation and put it here. 
        private static double expectedQUnderEpsilonPi(int state2)
        {
            double maxActionValue = max(Models.expectedSARSAList[state2, 0], Models.expectedSARSAList[state2, 1], Models.expectedSARSAList[state2, 2],
                Models.expectedSARSAList[state2, 3]);

            double x = (1 - epsilonpi) * maxActionValue + (epsilonpi / 4) * 
                (Models.expectedSARSAList[state2, 0] + Models.expectedSARSAList[state2, 1] + Models.expectedSARSAList[state2, 2] + 
                Models.expectedSARSAList[state2, 3]);

            return x;
        }

        public static void beginExpectedSARSA()
        {


            int stepCount = 1;
            int G = 0; //Return begins at 0
            int state = 1; //We begin in state 1

            while (state != 100)
            {
                int action = Policies.equiprobableRandomPolicy(random);
                int reward = RewardMappings.simulateStateAction(state, action);
                int state2 = Models.stateModification(state, action);
                Console.WriteLine("state" + state + "action" + action + "Reward" + reward);

                //Equation for Expected Sarsa is here. I divided it into two bits because it was overly complex
                //appearing. And that is something I would love to avoid here. 
                Models.expectedSARSAList[state, action] = Models.expectedSARSAList[state, action] + alpha * (reward + gamma * expectedQUnderEpsilonPi(state2)
                    - (Models.expectedSARSAList[state, action]));
                


                G = G + reward;
                state = state2;
                stepCount++;

            }

            if (state == 100)
            {
                Console.WriteLine("We successfully hit the goal state in "+ stepCount + " steps! :D!");
            }
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);


        }

    }
}
