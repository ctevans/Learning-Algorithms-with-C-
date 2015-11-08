using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* This is where the models of the application are going to be located, so this is where
 * the core arrays, etc, that are used in the algorithm will be located!
 * 
 * I will also provide methods to access and modify these values here. Keeping it clean :)
 */

namespace ConsoleApplication1
{
    //Public because I want this accessible everywhere, static because I only want ONE of these to ever exist.
    //There should never be more than just this. That would defeat the entire point.
    public static class Models
    {

        //Alright, this one is a biggy. This is going to be the fundamental list that will be
        //iterated over in expectedSARSA! This models class holds this list... keeping it in place!
        //In c# integer arrays are set to 0 by default, I may try letting the user start this program
        //with some sort of "Optmistic policy" later but for now 0's. More fun can be added later when it works! :3
        public static int[,] expectedSARSAList = new int[100, 4];

       


        //Let's say I want a single value returned from my list. This is going to be
        //how exactly I get that value. 
        public static int returnSingleValue()
        {
            return 0; //placeholder
        }


        //This is the model of the walls that I will be using throughout the application. It has
        //two main functions, it will take in the state and the action done and it will return
        //the new state to the caller.
        public static int stateModification(int state, int action)
        {
            //Crude, but effective. I call my own reward mappings function and compare what value
            //I obtain from it to determine if it smashed into a wall. 
            int didItHitAWall = RewardMappings.simulateStateAction(state, action);

            //If statement, where if it DID hit a wall... well... we'll handle that!
            if (didItHitAWall == -5)
            {
                return state; //The state is returned. NO CHANGE IN THE STATE!
            }

            //Now we enter the block where if it didn't hit a wall we return the new state number
            if (action == 0)
            {
                return state - 10; //return UP state  (and yes my beautiful grid lets it be this easy)
            }

            else if (action == 1)
            {
                return state + 1; //return RIGHT state 
            }

            else if (action == 2)
            {
                return state + 10; //return DOWN state
            }

            else
            {
                return state - 1;
            }
        }

    }

}
