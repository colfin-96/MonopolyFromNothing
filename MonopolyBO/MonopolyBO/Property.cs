using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Property : Square
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Mortgage { get; set; }
        public bool IsMortgaged { get; set; }
        public int Owner { get; set; }
        public bool IsOwned { get{if (Owner == 0)return false;return true;}}
        public int NoHouses { get; set; }
        public int CostOfHouse { get; set; }
        public string Colour { get; set; }
        public bool doesThisWork { get; set; }



    }
}
