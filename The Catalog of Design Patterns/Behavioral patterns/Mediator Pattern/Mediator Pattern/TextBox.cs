using System;

namespace Mediator_Pattern
{
    //Component
    class TextBox : Control
    {
        public string Text { get; set; }
        public event Action TextChanged;

        public void TextBoxTextChanged()
        {
            TextChanged?.Invoke();
        }
    }
}
