using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Initializations
    {
        public static Random random = new Random();

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
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);
            Console.WriteLine(G);

        }

    }
}
