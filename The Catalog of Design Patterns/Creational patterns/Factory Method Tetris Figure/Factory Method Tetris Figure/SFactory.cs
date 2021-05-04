namespace Factory_Method_Tetris_Figure
{
    class SFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new S();
        }
    }
}
