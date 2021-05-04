using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Tetris_Figure
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public int[,] Description { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(50);

            for (int i = 0; i < Description.GetLength(0); i++)
            {
                for (int j = 0; j < Description.GetLength(0); j++)
                {
                    if (Description[i,j]!=0)
                    {
                        stringBuilder.Append("*");
                    }
                    else
                    {
                        stringBuilder.Append(" ");
                    }
                }
                stringBuilder.Append("\n");

            }
            return Name + " : "+Color+"\n" + stringBuilder.ToString(); 
        }
    }
}
