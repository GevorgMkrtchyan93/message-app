using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    class Envelop : IMessage, IPhysicalMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Envelop");
        }
    }
}
