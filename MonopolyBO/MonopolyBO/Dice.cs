using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MonopolyBO
{
    class Dice
    {
        public  int  die1,die2;

        public Dice()
        {
            die1 = -1;
            die2 = -1;
        }


        public int Roll()
        {
            Random rnd = new Random();
            die1 = rnd.Next(1, 6);
            die2 = rnd.Next(1, 6);
            return die1+die2; 
        }

        public bool Equal()
        {
            return die1 == die2;
        }
    }
}
