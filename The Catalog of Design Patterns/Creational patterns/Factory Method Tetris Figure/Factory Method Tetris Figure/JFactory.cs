namespace Factory_Method_Tetris_Figure
{
    class JFactory : IFigureFactory
    {
        public Figure Create()
        {
            return new J();
        }
    }
}
