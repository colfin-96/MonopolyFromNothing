using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Token { get; set; }
        public int Money { get; set; }
        public int Position { get; set; }
        public bool IsInJail {get{if (Position == 10)return true;return false;}}

        public int[] Properties { get; set; }
        public int[] Cards { get; set; }





        public void Play()
        {
            if (IsInJail)
                PlayJail();
            else
            {

            }
        }

        private void PlayJail()
        {

        }

    }
}
