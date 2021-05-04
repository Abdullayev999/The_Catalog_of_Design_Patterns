using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Task
{
    public class Mediator
    {
        public List<ChatForm> clients;
        public List<string> messangers;

        public Mediator(EnterForm enter)
        {
            enter.enter += ClientJoined;
            clients = new List<ChatForm>();
            messangers = new List<string>();
        }

        public void ClientJoined(string name)
        {
            var newChat = new ChatForm(name);
            newChat.nameLabel.Text = name;
            clients.Add(newChat);
            messangers.Add($"{newChat.Name} ({DateTime.Now.ToShortTimeString()}) : joined\n");
            newChat.send += MessageSent;
            newChat.close += ClientLeft;
            RefreshChat();
            newChat.Show();
        }
        public void ClientLeft(ChatForm chat)
        {
            int index = clients.IndexOf(chat);
            clients.RemoveAt(index);
            RefreshChat();
            
            messangers.Add($"{chat.Name} ({DateTime.Now.ToShortTimeString()}) : left\n");
        }
        public void MessageSent(ChatForm chat)
        {
            messangers.Add($"{chat.Name} ({DateTime.Now.ToShortTimeString()}) :  {chat.chatTextBox.Text}");
            chat.chatTextBox.Clear();
            RefreshChat();
        }

        public void RefreshChat()
        {
            foreach (var item in clients)
            {
                item.listBox.Items.Clear();
                item.listBox.Items.AddRange(messangers.ToArray());
            }
        }
    }
}
