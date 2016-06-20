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
            return rnd.Next(2, 13); // creates a number between 1 and 12 (2 dice) - edit: needs to be between 2 and 12 because 2 times 1 is 2 ;)
        }
    }
}
