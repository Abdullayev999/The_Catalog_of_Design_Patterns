using System;

namespace Mediator_Pattern
{
    //Component
    class Button : Control
    {
        public bool Enabled { get; set; } 
        public event Action Click;

        public void ButtonClick()
        {
            if (Enabled)
            {
                Click?.Invoke();
            }
        }
    }
}
