using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    public interface IMessage
    {
        void SendMessage();
    }

    public interface IPhysicalMessage
    {
        void SendMessage();
    }
    public class Notification
    {
        private readonly IMessage _message;
        private readonly IPhysicalMessage _physicalMessage;
        public Notification(IMessage message)
        {
            _message = message;
        }

        public Notification(IPhysicalMessage physicalMessage)
        {
            _physicalMessage = physicalMessage;
        }
        public void DoNotify()
        {
            _message.SendMessage();
        }
        public void DoNotifyPhysical()
        {
            _physicalMessage.SendMessage();
        }
    }
}