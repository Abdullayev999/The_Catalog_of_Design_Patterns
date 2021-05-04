using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Tetris_Figure
{
    interface IFigureFactrory
    {
        Figure Creator();
    }
}
