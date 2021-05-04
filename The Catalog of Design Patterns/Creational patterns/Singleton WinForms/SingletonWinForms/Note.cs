namespace SingletonWinForms
{
    public class Note
    {
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}