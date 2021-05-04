namespace Factory_Method_Tetris_Figure
{
    class LFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new L();
        }
    }
}
