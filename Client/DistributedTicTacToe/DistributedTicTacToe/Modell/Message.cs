using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedTicTacToe.Modell
{
    public class Message
    {
        private MessageType type;
        public MessageType Type { get; set; }
        
        public Message()
        {
        }
       

    }
}
