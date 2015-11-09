using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /** This class holds all of the policies that will be utilized in this code. 
      * Simply put, these are what decide which action we take.
      *
      * Policies here are represented numerically. 
      * Translation:
      * 0 = UP
      * 1 = RIGHT
      * 2 = DOWN
      * 3 = LEFT
      */
    class Policies
    {
    
        //All chances are equally probable with this policy! 
        //Nothing greedy about this at all. Nothing fancy. Pure randomness.
        public static int equiprobableRandomPolicy(Random random)
        {

            
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

        public static int behaviourPolicy(int state)
        {
            int epsilonRandom = Initializations.random.Next();
            
            if (epsilonRandom > Initializations.Epsilonmu) //GREEDY POLICY FOLLOWED
            {
                return (argMaxAction(state));
            }

            else //Exploration!
            {
                return equiprobableRandomPolicy(Initializations.random);

            }

        }

        public static int argMaxAction(int state)
        {
            //First check if the first action is the highest, if it is then reutrn first action.
            if (Models.expectedSARSAList[state,0] > Models.expectedSARSAList[state,1] && Models.expectedSARSAList[state, 0] > Models.expectedSARSAList[state,2]
                && Models.expectedSARSAList[state, 0] > Models.expectedSARSAList[state, 3])
            {
                return 0;
            }


            //Secondly check if the second action is the highest, return second if it is the highest value.
            else if (Models.expectedSARSAList[state, 1] > Models.expectedSARSAList[state, 0] && 
                Models.expectedSARSAList[state, 1] > Models.expectedSARSAList[state, 2] && Models.expectedSARSAList[state, 1] > Models.expectedSARSAList[state, 3])
            {
                return 1;
            }

            else if (Models.expectedSARSAList[state, 2] > Models.expectedSARSAList[state, 0] && Models.expectedSARSAList[state, 2] >
                Models.expectedSARSAList[state, 1] && Models.expectedSARSAList[state, 2] > Models.expectedSARSAList[state, 3])
            {
                return 2;
            }

            else if (Models.expectedSARSAList[state, 3] > Models.expectedSARSAList[state, 0] && Models.expectedSARSAList[state, 3] >
                Models.expectedSARSAList[state, 1] && Models.expectedSARSAList[state, 3] > Models.expectedSARSAList[state, 2])
            {
                return 3;
            }

            else //As in they are all equal. (Critical because I don't want to have it hit a wall nonstop.
            {
                int randomChoice = Initializations.random.Next() % 3;
                return randomChoice;


            }


        }

    }
}
