using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAkka.Messages;

namespace TestAkka.Actors
{
    public class PingActor:ReceiveActor
    {
        public PingActor()
        {
            Receive<PingMessage>(message => Echo(message));
        }

        private void Echo(PingMessage message)
        {
            Console.WriteLine(message.Message);
        }
    }
}
