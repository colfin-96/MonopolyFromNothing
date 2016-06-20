using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Property : Square
    {
        public int PropertyId { get; set; }
        public int Value { get; set; }
        public int Mortgage { get { return Value / 2; } } // Mortgage is always half the value
        public bool IsMortgaged { get; set; }
        public int OwnerId { get; set; }
        public bool IsOwned { get { if (OwnerId == -1) return false; return true; } }
        public int GroupId { get; set; }

        public int NoHouses { get; set; }
        public int CostOfHouse { get { return SideOfBoard * 50; } }
        public int SideOfBoard { get; set; }


    }
}
