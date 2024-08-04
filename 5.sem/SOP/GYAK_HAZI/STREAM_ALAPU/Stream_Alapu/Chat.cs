using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Alapu
{
    public class Chat
    {
        public string Name { get; set; }
        public List<Message> Messages { get; } = new List<Message>();
    }
}
