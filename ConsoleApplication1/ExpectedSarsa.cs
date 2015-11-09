using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExpectedSarsa
    {
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

            double x = (1 - Initializations.Epsilonpi) * maxActionValue + (Initializations.Epsilonpi / 4) *
                (Models.expectedSARSAList[state2, 0] + Models.expectedSARSAList[state2, 1] + Models.expectedSARSAList[state2, 2] +
                Models.expectedSARSAList[state2, 3]);

            return x;
        }

        public static void expectedSARSA(bool printFlag, int trialNumber)
        {
            int stepCount = 1;
            int G = 0; //Return begins at 0
            int state = 1; //We begin in state 1

            while (state != 100)
            {
                int action = Policies.behaviourPolicy(state);
                int reward = RewardMappings.simulateStateAction(state, action);
                int state2 = Models.stateModification(state, action);
                //Console.WriteLine("state" + state + "action" + action + "Reward" + reward);

                //Equation for Expected Sarsa is here. I divided it into two bits because it was overly complex
                //appearing. And that is something I would love to avoid here. 
                Models.expectedSARSAList[state, action] = Models.expectedSARSAList[state, action] + Initializations.Alpha * 
                    (reward + Initializations.Gamma * expectedQUnderEpsilonPi(state2) - (Models.expectedSARSAList[state, action]));



                G = G + reward;
                state = state2;
                stepCount++;

            }

            if (state == 100)
            {
                //Console.WriteLine("We successfully hit the goal state in " + stepCount + " steps! :D!");
            }

            //Some mercy on the terminal console. Only printing every 1,000 steps.
            if (printFlag == true)
            {
                Console.WriteLine("Trial" + trialNumber + " took: " + (stepCount-1) + " steps. And the return is: " + G);
            }




            //reset step count
            stepCount = 0;


        }


    }
}
