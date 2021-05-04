using System.Collections.Generic;

namespace Mediator_Pattern
{
    //Component
    class ListBox : Control
    {
        public List<string> Items { get; set; }
        public ListBox()
        {
            Items = new List<string>();
        }
    }
}
