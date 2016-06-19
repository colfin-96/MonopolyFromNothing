using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Dice
    {

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 13); // creates a number between 1 and 12 (2 dice)
        }
    }
}
