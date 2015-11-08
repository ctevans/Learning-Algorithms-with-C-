using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RewardMappings
    {
        static public int simulateStateAction(int state, int action)
        {

            state = state - 1;
            //HERE IS HOW THIS BIG TABLE WORKS!:
            //Rows = STATES. We have 100 states.
            //Columns = ACTIONS. We have 4 actions per state!
            //I index into this multidimensional array in order to pick out the reward when a 
            //particular state-action pair is taken. It merely was the simplest and most 
            //clean-cut way to represent this all. I will comment with some indexes to keep track.
            //
            //Also if you'd kindly note, yes... indeed... this does match the print output that occurs! 
            //More details: Anything that DOES NOT cause the agent to hit the GOAL state has a reward of -1


            //THESE VALUES RIGHT BELOW HERE BEFORE THE TABLE ARE THE REWARD VALUES.
            //I USED VARIABLES HERE SO I COULD EASILY CHANGE THE REWARD SCHEME. (Without causing undue agony and pain.)
            //I describe what they are beside them.

            int d = -1; //d = DEFAULT. As in everything that isn't a wall or goal state or have some special quality to it!
            int g = 50; //g = GOAL. As in the final goal state! Huzzah! 
            int w = -5; //w = WALL. As in the agent attempted to pass through a wall. This is a big big big no. 
            int t = 0;  //t = TERMINAL. As in we've hit a terminal state. 

            //Policies here are represented numerically. 
            // Translation BY INDEXES (Index = 0-3):
            // 0 = UP
            // 1 = RIGHT
            // 2 = DOWN
            // 3 = LEFT

            int[,] stateRewardArray = new int[100, 4] {
                {w,d,d,w}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,d,d,d}, {w,w,d,d}, //1-10

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //11-20

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //21-30

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //31-40

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //41-50

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //51-60

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //61-70

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,d,d}, //71-80

                {d,d,d,w}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,d,d,d}, {d,w,g,d}, //81-90

                {d,d,w,w}, {d,d,w,d}, {d,d,w,d}, {d,d,w,d}, {d,d,w,d}, {d,d,w,d}, {d,d,w,d}, {d,d,w,d}, {d,g,w,d}, {t,t,t,t} }; //91-100 (fin)


            return stateRewardArray[state, action];
        }
    }
}
