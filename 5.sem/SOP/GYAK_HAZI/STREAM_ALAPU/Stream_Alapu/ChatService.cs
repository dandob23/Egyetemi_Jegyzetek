using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Alapu
{
    public class ChatService
    {
        private List<Chat> chats = new List<Chat>();

        public void CreateChat(string name)
        {
            chats.Add(new Chat { Name = name });
        }

        public List<Chat> GetChats()
        {
            return chats;
        }

        public Chat GetChatByName(string name)
        {
            return chats.FirstOrDefault(chat => chat.Name == name);
        }

        public void SendMessage(Chat chat, string sender, string content)
        {
            chat.Messages.Add(new Message
            {
                Sender = sender,
                Content = content,
                Timestamp = DateTime.Now
            });
        }
    }
}
