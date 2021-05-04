namespace Factory_Method_Tetris_Figure
{
    class TFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new T();
        }
    }
}
