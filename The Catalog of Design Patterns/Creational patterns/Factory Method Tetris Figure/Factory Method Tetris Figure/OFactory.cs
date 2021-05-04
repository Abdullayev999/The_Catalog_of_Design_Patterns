namespace Factory_Method_Tetris_Figure
{
    class OFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new O();
        }
    }
}
