namespace Factory_Method_Tetris_Figure
{
    class ZFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new Z();
        }
    }
}
