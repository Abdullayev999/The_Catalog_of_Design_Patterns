using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Tetris_Figure
{
    class S : Figure
    {
        public S()
        {
            Name = "<< S >>";
            Color = "Orange";
            Description = new int[4, 4]
            {
                {0,0,0,0},
                {0,0,0,0},
                {0,0,1,1},
                {1,1,1,0}
            };
        }
    }
}
