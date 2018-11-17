using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedTicTacToe.Modell
{
    public class MessageFactory
    {
        public Message CreateMessage(MessageType type)
        {
            switch (type)
            {
                case MessageType.connect:
                    break;
                case MessageType.getConnectedUsers:
                    break;
                case MessageType.gameMove:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
