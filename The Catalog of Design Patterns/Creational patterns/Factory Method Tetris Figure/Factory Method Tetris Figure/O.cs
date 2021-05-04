using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Tetris_Figure
{
    class O : Figure
    {
        public O()
        {
            Name = "<< O >>";
            Color = "Yellow";
            Description = new int[4, 4]
            {
                {0,0,0,0},
                {1,1,1,0},
                {1,1,1,0},
                {1,1,1,0}
            };
        }
    }
}
