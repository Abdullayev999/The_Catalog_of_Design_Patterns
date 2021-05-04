namespace Factory_Method_Tetris_Figure
{
    class IFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new I();
        }
    }
}
