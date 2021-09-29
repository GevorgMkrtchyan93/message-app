using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp
{
    class Drone : IMessage, IPhysicalMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Drone");
        }
    }
}
