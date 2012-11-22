using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Messaging;
using System.Text;

namespace ws_srvc_mq
{
    enum MessageType { mtTest = 0, mtUserMsg = 1}

    public class MessageBase
    {

    }

    public class Message : MessageBase
    {
        private MessageType _MessageType;
        public MessageType MessageType
        {
            get
            {
                return _MessageType;
            }
        }
        public Message(MessageType MessageType)
        {
            _MessageType = MessageType;
        }
    }

    public class MessageService
    { 
        public bool RecvMsg(MessageBase msg)
        {
            bool ret = false;
            using (MessageQueue queue = MessageQueue.Create(@". \myqueue"))
            {
                queue.Label = "First Queue";
                
            }
            return ret;
        }
        
    }

}