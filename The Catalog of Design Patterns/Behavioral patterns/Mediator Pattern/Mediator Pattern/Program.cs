namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Form();

            //User UI actions (fake)
            form.NameTextBox.Text = "Test";
            form.NameTextBox.TextBoxTextChanged();
            form.AddButton.ButtonClick();
        }
    }

    //Base Component
    abstract class Control{ }
}
