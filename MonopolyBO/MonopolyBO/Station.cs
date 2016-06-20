using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Station : Square
    {
        public int StationId { get; set; }
        
        public int Value { get; set; }
    }
}
