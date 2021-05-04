using System;
using System.Collections.Generic;
using System.Threading;

namespace Factory_Method_Tetris_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            List<IFigureFactory> figureFactorys = new List<IFigureFactory>();


            figureFactorys.Add(new LFactory());
            figureFactorys.Add(new JFactory());
            figureFactorys.Add(new TFactory());
            figureFactorys.Add(new ZFactory());
            figureFactorys.Add(new IFactory());
            figureFactorys.Add(new OFactory());
            figureFactorys.Add(new SFactory());
           

            for (int i = 0; i < figureFactorys.Count; i++)
            {
                Figure figure = figureFactorys[i].Create();
                figures.Add(figure);
                Console.WriteLine("Figruse =>  " + figure);
                Console.WriteLine("-----------------------");
            }

        }
    }
}
