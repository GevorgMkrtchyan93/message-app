using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    class MMS: IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("MMS");
        }
    }
}
