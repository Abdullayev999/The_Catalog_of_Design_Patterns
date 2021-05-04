using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_Task
{
    interface IChat
    {
        string Name { get; set; }
        event Action<ChatForm> send;
        event Action<ChatForm> close;
    }
    public partial class ChatForm : Form , IChat
    {
        public ChatForm(string name)
        {
            InitializeComponent();
            Name = name;
        }

        public event Action<ChatForm> send;
        public event Action<ChatForm> close;

        protected override void OnClosing(CancelEventArgs e)
        {
            close?.Invoke(this);
            base.OnClosing(e);
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            send?.Invoke(this);
            chatTextBox.Clear();
        }
    }
}
