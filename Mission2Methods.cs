using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Mission2Methods
    {

        public static int[] diceRolls(int numRolls)
        {
            int[] diceRollsCount = new int[11];
            Random random = new Random();
            int die1 = 0;
            int die2 = 0;
            int value = 0;

            for (int i = 0; i < numRolls; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                value = die1 + die2;

                diceRollsCount[value - 2]++;
            }

            return diceRollsCount;

        }

    }
}
